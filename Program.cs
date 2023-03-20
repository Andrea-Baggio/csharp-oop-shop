Prodotto prodotto = new Prodotto("Nome prodotto", "Descrizione prodotto", 19.99, 22);
Console.WriteLine($"Codice prodotto: {prodotto.code}");
Console.WriteLine($"Prezzo prodotto: {prodotto.price}");
Console.WriteLine($"Prezzo tassato del prodotto: {prodotto.iva}"); //problrma con i centesimi