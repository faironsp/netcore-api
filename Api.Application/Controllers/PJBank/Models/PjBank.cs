using System;

namespace Api.Application.Controllers.PJBank.Models
{
    public class PjBank
    {
        public enum status
        {
            confirmado,
            rejeitado,
            baixado,
            pendente
        }

        public string operacao { get; set; }
        public string tipo { get; set; }

        public string valor { get; set; }
        public string valor_pago { get; set; }
        public string valor_liquido { get; set; }
        public string valor_tarifa { get; set; }

        public bool? pagamento_duplicado { get; set; }

        public string nosso_numero { get; set; }
        public string nosso_numero_original { get; set; }
        public string id_unico { get; set; }
        public string id_unico_original { get; set; }
        public string pedido_numero { get; set; }
        public string banco_numero { get; set; }
        public string token_facilitador { get; set; }

        public string data_vencimento { get; set; }
        public string data_pagamento { get; set; }
        public string data_credito { get; set; }

        public string credencial { get; set; }
        public string chave { get; set; }

        public status registro_sistema_bancario { get; set; }
        public string registro_rejeicao_motivo { get; set; }
    }
}