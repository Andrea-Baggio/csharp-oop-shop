Prodotto prodotto = new Prodotto("Penna a sfera Bic", "Penna a sfera blu, gel", 3.99, 22);

Console.WriteLine($"Codice prodotto: {prodotto.code}");
Console.WriteLine($"Prezzo prodotto: {prodotto.price}£");
Console.WriteLine($"Prezzo tassato del prodotto: {prodotto.iva}£"); //problema con i centesimi
Console.WriteLine($"Nome completo del prodotto: {prodotto.fullname}");