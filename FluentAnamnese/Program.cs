using FluentAnamnese.Components;
using Microsoft.FluentUI.AspNetCore.Components;
using Microsoft.KernelMemory.AI.Ollama;
using Microsoft.KernelMemory;
using Microsoft.SemanticKernel;
using OpenAI;
using System.ClientModel;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();
builder.Services.AddFluentUIComponents();

var ollamaUrl = builder.Configuration["OllamaSettings:BaseUrl"]!;
var ollamaModel = builder.Configuration["OllamaSettings:Model"]!;

var ollamaConfig = new OllamaConfig
{
    Endpoint = ollamaUrl,
    TextModel = new OllamaModelConfig(ollamaModel),
    EmbeddingModel = new OllamaModelConfig(ollamaModel)
};

var kernel = builder.Services.AddKernel();
kernel.Services.AddOpenAIChatCompletion(ollamaModel, new OpenAIClient(new ApiKeyCredential(builder.Configuration["OllamaSettings:ApiCredential"]!),
new OpenAIClientOptions { Endpoint = new Uri(ollamaUrl) }));

kernel.Services.AddOllamaTextGeneration(ollamaConfig);

builder.Services.AddKernelMemory(kmBuilder =>
{
    kmBuilder
        .WithOllamaTextGeneration(ollamaConfig)
        .WithOllamaTextEmbeddingGeneration(ollamaConfig);
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
