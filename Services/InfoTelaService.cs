namespace SorteioAPI.Services
{

    using SorteioAPI.Models;
    using System;
    using System.Collections.Generic;

    namespace MinhaApi.Services
    {
        public class InfoTelaService
        {
            // Simulação de uma regra de negócio para buscar dados com base no CPF
            public InfoTelaResponse GetInfoByCpf(string cpf)
            {
                // Aqui pode ser onde você busca os dados do banco ou aplica as regras de negócio
                if (!string.IsNullOrWhiteSpace(cpf))
                {
                    return new InfoTelaResponse
                    {
                        VibesAcumulados = 1200,
                        NumerosDaSorteQuantidade = 4,
                        SeusNumerosDaSorte = new List<NumeroDaSorte>
                    {
                        new NumeroDaSorte { Numero = "62091", RecebidoEm = new DateTime(2024, 6, 18) },
                        new NumeroDaSorte { Numero = "94920", RecebidoEm = new DateTime(2024, 6, 25) },
                        new NumeroDaSorte { Numero = "27171", RecebidoEm = new DateTime(2024, 6, 26) },
                        new NumeroDaSorte { Numero = "75947", RecebidoEm = new DateTime(2024, 6, 26) }
                    }
                    };
                }
                else
                {
                    return null; // CPF não encontrado
                }
            }
        }
    }


}
