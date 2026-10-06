using Microsoft.EntityFrameworkCore;
using ProdutosApi.Domain;

namespace ProdutosApi.Data;

public static class DbSeeder
{
    public static async Task PopularAsync(AppDbContext context)
    {
        // Só insere se a tabela estiver vazia.
        if (await context.Produtos.AnyAsync())
            return;

        var agora = DateTime.UtcNow;

        var produtos = new List<Produto>
        {
            // ZONA ILUMINADA (0 a 200m): timbres limpos e brilhantes
            new()
            {
                Nome = "Violão Eletroacústico Aurora",
                Descricao = "Tampo de abeto e som aberto, com agudos cristalinos. Ideal para dedilhados e introduções limpas.",
                Preco = 3200.00m,
                Estoque = 12,
                Tipo = "Violão",
                Zona = "Iluminada",
                Profundidade = 20,
                Timbre = 1,
                CriadoEm = agora
            },
            new()
            {
                Nome = "Fender Stratocaster",
                Descricao = "Três captadores single coil e timbre estalado. Brilha em limpos, arpejos e passagens atmosféricas.",
                Preco = 9800.00m,
                Estoque = 6,
                Tipo = "Guitarra 6 cordas",
                Zona = "Iluminada",
                Profundidade = 50,
                Timbre = 1,
                CriadoEm = agora
            },
            new()
            {
                Nome = "Gibson Les Paul Custom",
                Descricao = "Captadores humbucker originais, sustain longo e médios encorpados. O ponto de partida para riffs pesados.",
                Preco = 23500.00m,
                Estoque = 3,
                Tipo = "Guitarra 6 cordas",
                Zona = "Iluminada",
                Profundidade = 100,
                Timbre = 2,
                CriadoEm = agora
            },
            new()
            {
                Nome = "Pedal de Reverb Maré",
                Descricao = "Reverb amplo, do ambiente sutil ao espaço infinito. Dá profundidade a qualquer passagem limpa.",
                Preco = 1450.00m,
                Estoque = 18,
                Tipo = "Pedal",
                Zona = "Iluminada",
                Profundidade = 150,
                Timbre = 2,
                CriadoEm = agora
            },

            // ZONA CREPUSCULAR (200 a 1000m): a luz diminui e o som encorpa
            new()
            {
                Nome = "ESP LTD EC-1000",
                Descricao = "Captadores ativos e braço rápido. Ataque definido e graves firmes para afinações mais baixas.",
                Preco = 8900.00m,
                Estoque = 5,
                Tipo = "Guitarra 6 cordas",
                Zona = "Crepuscular",
                Profundidade = 400,
                Timbre = 3,
                CriadoEm = agora
            },
            new()
            {
                Nome = "Fender Precision Bass",
                Descricao = "O grave redondo e direto que segura a base da banda. Quatro cordas e presença em qualquer mix.",
                Preco = 11200.00m,
                Estoque = 4,
                Tipo = "Baixo 4 cordas",
                Zona = "Crepuscular",
                Profundidade = 600,
                Timbre = 3,
                CriadoEm = agora
            },
            new()
            {
                Nome = "Ibanez RG 7 Cordas",
                Descricao = "A sétima corda abre espaço para riffs mais graves sem perder a definição dos solos.",
                Preco = 7600.00m,
                Estoque = 7,
                Tipo = "Guitarra 7 cordas",
                Zona = "Crepuscular",
                Profundidade = 700,
                Timbre = 3,
                CriadoEm = agora
            },
            new()
            {
                Nome = "Pedal de Distorção Correnteza",
                Descricao = "Distorção densa com médios cortantes. Transforma qualquer acorde em parede sonora.",
                Preco = 980.00m,
                Estoque = 20,
                Tipo = "Pedal",
                Zona = "Crepuscular",
                Profundidade = 900,
                Timbre = 4,
                CriadoEm = agora
            },

            // ZONA ABISSAL (a partir de 4000m): sem luz, só peso
            new()
            {
                Nome = "Ibanez RG 8 Cordas",
                Descricao = "Oito cordas para descer até onde o baixo costuma ficar. Graves tensos e definidos para djent e metal moderno.",
                Preco = 12900.00m,
                Estoque = 3,
                Tipo = "Guitarra 8 cordas",
                Zona = "Abissal",
                Profundidade = 4000,
                Timbre = 4,
                CriadoEm = agora
            },
            new()
            {
                Nome = "Pedal de Fuzz Abismo",
                Descricao = "Fuzz saturado e espesso, que engrossa o som até ele virar pressão.",
                Preco = 1250.00m,
                Estoque = 14,
                Tipo = "Pedal",
                Zona = "Abissal",
                Profundidade = 4500,
                Timbre = 4,
                CriadoEm = agora
            },
            new()
            {
                Nome = "Ibanez RG 9 Cordas",
                Descricao = "Nove cordas e o registro mais grave que uma guitarra alcança. Peso máximo, pode ate dispensar o contrabaixo.",
                Preco = 14900.00m,
                Estoque = 2,
                Tipo = "Guitarra 9 cordas",
                Zona = "Abissal",
                Profundidade = 5000,
                Timbre = 5,
                CriadoEm = agora
            },
            new()
            {
                Nome = "Baixo 5 Cordas Hadal",
                Descricao = "A quinta corda leva o grave ao limite. Subgraves que se sentem no peito antes de se ouvir.",
                Preco = 13800.00m,
                Estoque = 2,
                Tipo = "Baixo 5 cordas",
                Zona = "Abissal",
                Profundidade = 6000,
                Timbre = 5,
                CriadoEm = agora
            }
        };

        await context.Produtos.AddRangeAsync(produtos);
        await context.SaveChangesAsync();
    }
}