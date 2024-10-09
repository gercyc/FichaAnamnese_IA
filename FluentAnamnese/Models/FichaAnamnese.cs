using System.ComponentModel.DataAnnotations;

namespace FluentAnamnese.Models
{
    public class FichaAnamnese
    {
        [Required(ErrorMessage = $"O campo {nameof(Nome)} é obrigatório")]
        public string Nome { get; set; }

        public DateTime? DataNascimento { get; set; }

        [Required(ErrorMessage = $"O campo {nameof(Naturalidade)} é obrigatório")]
        public string Naturalidade { get; set; }

        [Required(ErrorMessage = $"O campo {nameof(Nacionalidade)} é obrigatório")]
        public string Nacionalidade { get; set; }

        [Required(ErrorMessage = $"O campo {nameof(Endereco)} é obrigatório")]
        public string Endereco { get; set; }

        [Required(ErrorMessage = $"O campo {nameof(Fone)} é obrigatório")]
        public string Fone { get; set; }

        [Required(ErrorMessage = $"O campo {nameof(Email)} é obrigatório")]
        public string Email { get; set; }

        [Required(ErrorMessage = $"O campo {nameof(Peso)} é obrigatório")]
        public decimal Peso { get; set; }

        [Required(ErrorMessage = $"O campo {nameof(Estatura)} é obrigatório")]
        public decimal Estatura { get; set; }

        [Required(ErrorMessage = $"O campo {nameof(Objetivo)} é obrigatório")]
        public string Objetivo { get; set; }

        public bool PraticaAtividadeFisica { get; set; }

        public int AnosPraticaAtividadeFisica { get; set; }

        public string? TipoAtividadeFisica { get; set; }

        public bool JaPraticouAlgumaVez { get; set; }

        public int RefeicoesDia { get; set; }

        public bool DietaSuplementacao { get; set; }

        public string? TipoDietaSuplementacao { get; set; }

        public bool CasoObesidadeFamilia { get; set; }

        public int HorasSonoNoite { get; set; }

        public bool Fumante { get; set; }

        public int QuantidadeCigarrosDia { get; set; }

        public int AnosParouFumar { get; set; }

        public bool ConsomeAlcool { get; set; }

        public string TipoBebidaAlcolica { get; set; }

        public int DiasConsumoAlcoolSemanal { get; set; }

        public bool JaLesionouPraticandoExecicios { get; set; }
        public string? LesoesExistentesDecorrentesDeExercicio { get; set; }

        public bool UtilizaAlgumaMedicacao { get; set; }
        public string? MedicamentosUtilizados { get; set; }

        public string? PatologiasQuejaTeveAnteriormente { get; set; }
        public string? ObservacoesDoPacienteAoPersonal { get; set; }

    }
}
