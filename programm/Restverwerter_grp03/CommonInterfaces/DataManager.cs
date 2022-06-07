using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using CommonInterfaces.Properties;
using Microsoft.VisualBasic;

namespace CommonInterfaces
{
    public class DataManager : IDataManager
    {
        public static DataManager dataManager = new();

        // Datenbank in der alle Rezepte iengsepichert sind mit jeweils gespeicherten Namen der Bilderdateien und Textdateien, in dem die Anleitung gespeichert ist.
        public List<Recipe> AllRecipes = new()
        {
            new Recipe("Spaghetti", 1, 3, 30, new[] { Resources.Spaghetti }, "Spaghetti", new List<Ingredient>()// Rezept 1
            {
                new("Spaghetti", 500, "g"),
                new("Tomatensauce", 250, "g"),
                new("Basilikum", 25, "g"),
                new("Tomate(n)", 5),
                new("Zwiebel(n)", 4)
            }),
            new Recipe("Italienischer Pizzateig", 2, 3, 25, new[] { Resources.Italienischer_Pizzateig }, "pizzateig", new List<Ingredient>()// Rezept 2
            {
                new("Wasser", 500, "ml"),
                new("Mehl", 925, "g"),
                new("Frischhefe", 40, "g"),
                new("Salz", 20, "g"),
                new("Olivenöl", 25, "ml"),
                new("Zucker", 1, "Prise")
            }),
            new Recipe("Leberkäse-Pfanne", 3, 1, 40, new[] { Resources.Leberkäse_Pfanne }, "Leberkäse", new List<Ingredient>()// Rezept 3
            {
                new("Leberkäse", 400, "g"),
                new("Speck (geräuchert)", 2),
                new("Sonnenblumenöl", 3, "EL"),
                new("Kartoffel(n)", 400, "g"),
                new("Salz", 1, "Prise"),
                new("Lauch", 250, "g"),
                new("Paprikaschote(n)", 2),
                new("Petersilie", 1)
            }),
            new Recipe("Rinderroulade(n) klassisch", 4, 1, 50, new[] { Resources.Rinderrouladen }, "Roulladen", new List<Ingredient>()// Rezept4
            {
                new("Rinderroulade(n)", 8),
                new("Zwiebel(n)", 5),
                new("Gewürzgurke(n)", 4),
                new("Speck", 12, "Scheiben"),
                new("Möhre(n)", 1)
            }),
            new Recipe("Sesam Nudeln", 5, 1, 15, new[] { Resources.Sesam_Nudeln }, "Sesamenoodle", new List<Ingredient>()// Rezept5
            {
                new("Eiernudeln", 8),
                new("Zwiebel(n)", 5),
                new("Gewürzgurke(n)", 4),
                new("Frühstücksspeck", 12, "Scheiben"),
                new("Möhre(n)", 1)
            }),
            new Recipe("Fleischbälle", 6, 1, 50, new[] { Resources.Fleischbälle }, "Meatballs", new List<Ingredient>()// Rezept6
            {
                new("Brot", 3),
                new("Ei(er)", 2),
                new("Worcestershire", 4),
                new("Rinderhackfleisch", 500, "g"),
                new("Schweinehackfleisch", 500, "g"),
                new("Milch", 1/3f, "tasse"),
                new("Knoblauchzehe(n)", 2),
                new("Petersilie", 1/2f, "bund"),
                new("Senf", 1, "EL"),
                new("Tomatenmark", 1, "TL")
            }),
            new Recipe("Trüffel-Käse Girasoli mit Zucchinisalat", 7, 2, 25, new[] { Resources.Trüffel_Käse_Girasoli_mit_Zuccinisalat }, "Trüffel_Käse_Girasoli_mit_Zucchinisalat", new List<Ingredient>()// Rezept7
            {
                new("Zucchini", 1),
                new("Pinienkern(e)", 20, "g"),
                new("Parmesan", 40, "g"),
                new("Petersilie"),
                new("Zitrone(n)", 1),
                new("Salz"),
                new("Pfeffer"),
                new("Trüffelöl"),
                new("Olivenöl", 20, "ml")
            }),
            new Recipe("Tortellini mit Ricotta, Spinat & Walnüssen", 8, 2, 35, new[] { Resources.Tortellini_mit_Ricotta__Spinat___Walnüssen }, "Tortellini_mit_Ricotta__Spinat___Walnüssen", new List<Ingredient>()// Rezept8
            {
                new("Zwiebel(n)", 1),
                new("Blattspinat", 500, "g"),
                new("Ricotta", 250, "g"),
                new("Knoblauchzehe(n)", 1),
                new("Olivenöl", 2, "EL"),
                new("Walnüsse", 80, "g"),
                new("Salz"),
                new("Schwarzer Pfeffer")
            }),
            new Recipe("Rhabarber-Reis mit Hähnchen & Kräuterjoghurt", 9, 1, 40, new[] { Resources.Rhabarber_Reis_mit_Hähnchen___Kräuterjoghurt }, "Rhabarber_Reis_mit_Hähnchen___Kräuterjoghurt", new List<Ingredient>() // Rezept9
            {
                new("Rhabarber", 400, "g"),
                new("Schalotte(n)", 200, "g"),
                new("Möhre(n)", 2),
                new("Knoblauchzehe(n)", 2),
                new("Petersilie", 2, "Bund"),
                new("Minze", 1, "Bund"),
                new("Zitrone(n)", 1),
                new("Naturjoghurt", 300, "g"),
                new("Öl", 5, "EL"),
                new("Mandelblättchen", 50, "g"),
                new("Basmatireis", 200, "g"),
                new("Gemüsebrühe", 500, "ml"),
                new("Hähnchenfilet", 600, "g"),
                new("Salz"),
                new("Pfeffer")
            }),
            new Recipe("Linguine Carbonara", 10, 2, 30, new[] { Resources.Linguine_Carbonara }, "Linguine_Carbonara", new List<Ingredient>()// Rezept10
            {
                new("Petersilie", 1 / 2f, "Bund"),
                new("Schnittlauch", 1 / 2f, "Bund"),
                new("Schlagsahne", 75, "g"),
                new("Ei(er)", 3),
                new("Gouda", 50, "g"),
                new("Linguine", 400, "g"),
                new("Leichtschinken", 85, "g"),
                new("Zwiebel(n)", 2),
                new("Kresse"),
                new("Geriebene Muskatnuss"),
                new("Salz"),
                new("Pfeffer")
            }),
            new Recipe("Butternut-Kürbis-Suppe", 11, 3, 60, new[] { Resources.Butternut_Kürbis_Suppe }, "Butternut_Kürbis_Suppe", new List<Ingredient>() // Rezept11
            {
                new("Butternut-Kürbis", 1, "kg"),
                new("Zwiebel(n)", 1),
                new("Knoblauch", 1),
                new("Ingwer", 1, "TL Geriebener "),
                new("Currypaste", 1, "TL"),
                new("Öl", 4, "EL"),
                new("Brauner Zucker", 1, "TL"),
                new("Gemüsebrühe", 250, "ml"),
                new("Kokosmilch", 200, "ml"),
                new("Orangensaft", 100, "ml"),
                new("Muskat"),
                new("Basilikum", 1, "Bund"),
                new("Salz"),
                new("Pfeffer")
            }),
            new Recipe("Gebackene Mettbrötchen", 12, 1, 30, new[] { Resources.Gebackene_Mettbrötchen }, "Gebackene_Mettbrötchen", new List<Ingredient>()// Rezept12
            {
                new("Knoblauchzehe(n)", 2),
                new("Zwiebel(n)", 2),
                new("Öl", 1, "EL"),
                new("Mett", 300, "g"),
                new("Getrockneter Thymian", 1, "TL"),
                new("Tomatenmark", 1, "EL"),
                new("Tomaten", 200, "g passierte "),
                new("Brötchen", 4, "Stück (je 200g)"),
                new("Geriebener Goudakäse", 50, "g"),
                new("Gewürzsalz"),
                new("Salz"),
                new("Pfeffer")
            }),
            new Recipe("Spinat-Crespelle mit Schinkenwurst", 13, 1, 75, new[] { Resources.Spinat_Crespelle_mit_Schinkenwurst }, "Spinat_Crespelle_mit_Schinkenwurst", new List<Ingredient>()// Rezept13
            {
                new("Blattspinat", 600, "g"),
                new("Ei(er)", 4),
                new("Vollkornmehl", 190, "g"),
                new("Milch", 275, "ml"),
                new("Zwiebel(n)", 2),
                new("Knoblauch", 1),
                new("Schinkenwurst", 70, "g"),
                new("Öl", 4, "EL"),
                new("Butter", 15, "g"),
                new("Kräuter-Frischkäse", 100, "g"),
                new("Gemüsebrühe", 125, "ml"),
                new("Bergkäse", 50, "g"),
                new("Geriebene Muskatnuss"),
                new("Salz"),
                new("Pfeffer")
            }),
            new Recipe("Filettopf", 14, 1, 50, new[] { Resources.Filettopf }, "Filettopf", new List<Ingredient>()// Rezept14
            {
                new("Schweinefilet", 600, "g"),
                new("Bacon", 8, "scheiben"),
                new("Öl", 2, "EL"),
                new("Zwiebel(n)", 3),
                new("Champignons", 300, "g"),
                new("Sahne", 200, "ml"),
                new("Schmand", 200, "g"),
                new("Tomatenmark", 2, "EL"),
                new("Paprikapulver", 1, "prise"),
                new("Getrocknete italienische Kräuter", 1, "EL"),
                new("Gemüsebrühe", 1, "TL"),
                new("Petersilie", 5, "Stiele"),
                new("Salz"),
                new("Pfeffer")
            }),
            new Recipe("Zebra-Marmorkuchen (Vegan)", 15, 3, 60, new[] { Resources.ZebraMarmorkuchen }, "Zebrakuchen", new List<Ingredient>() // Rezept 15
            {
                new("Dinkelmehl", 300, "g"),
                new("Speisestärke", 35, "g"),
                new("Sojamehl", 1, "EL"),
                new("Zucker", 175, "g"),
                new("Backpulver", 1, "EL"),
                new("Natron", 1 / 2f, "Teelöffel"),
                new("Salz", 1, "Prise"),
                new("pflanzliche Milch", 300, "ml"),
                new("Öl", 160, "ml geschmacksneutrales"),
                new("Vanilleextrakt", 1, "TL"),
                new("Zitronensaft", 2, "EL"),
                new("Orangenschale", 1 / 2f),
                new("Kakaopulver", 3, "EL"),
                new("dunkle Schokolade", 100, "g"),
                new("Walnüsse")
            }),
            new Recipe("Veganer Kartoffelsalat", 16, 3, 25, new[] { Resources._16 }, "_16", new List<Ingredient>()
            {
                new("Kartoffel(n)", 1, "kg"),
                new("Essiggurken", 5, "Süß-Saure"),
                new("Radieschen", 10),
                new("vegane Mayonnaise", 5, "EL"),
                new("Gurkensaft", 2, "EL"),
                new("Senf", 1, "TL"),
                new("Salz"),
                new("Pfeffer"),
                new("Petersilie", 1 / 2f, "Bund"),
                new("Zwiebel(n)", 2)
            }),
            new Recipe("Vegetarische Reispfanne", 17, 2, 30, new[] { Resources._17 }, "reispfanne_1426", new List<Ingredient>()
            {
                new("Basmatireis", 200, "g"),
                new("Zwiebel(n)", 2),
                new("Paprikaschote(n)", 1, "rote"),
                new("Champignons", 200, "g"),
                new("Tomate(n)", 3),
                new("Olivenöl", 2, "EL"),
                new("Paprikapulver", 1 / 2f, "Teelöffel rosenscharfen"),
                new("Oregano", 1, "TL"),
                new("Gemüsebrühe", 3, "EL"),
                new("Schmand", 50, "g"),
                new("Salz"),
                new("Pfeffer"),
                new("Feta", 200, "g")
            }),
            new Recipe("Vegetarisches Linsen-Chili mit Reis", 18, 2, 15, new[] { Resources._18 }, "vegetarisches_linsen_chili_mit_reis_653881", new List<Ingredient>()
            {
                new("Paprikaschote", 1, "rote"),
                new("Zuccini"),
                new("Staudensellerie", 70, "g"),
                new("Möhre"),
                new("Schalotte(n)"),
                new("Knoblauchzehe(n)"),
                new("Ingwer", 20, "g"),
                new("Kokosöl", 1, "EL"),
                new("Linsen", 80, "g gelbe"),
                new("Currypulver", 1, "TL"),
                new("Gemüsebrühe", 100, "ml"),
                new("geschälte Tomatenstücke", 150, "g"),
                new("Parboiled Reis", 200, "g"),
                new("Salz"),
                new("Petersilie", 5, "g"),
                new("Kichererbsen", 240, "g"),
                new("Pfeffer"),
                new("Limettensaft", 2, "EL")
            }),
            new Recipe("Ofenkartoffeln mit Brokkoli", 19, 3, 60, new[] { Resources._19 }, "ofenkartoffeln_mit_brokkoli_655738", new List<Ingredient>()
            {
                new("Frühkartoffel(n)", 500, "g kleine"),
                new("Rosmarin", 3, "Zweige"),
                new("Olivenöl", 4, "EL"),
                new("Salz"),
                new("Pfeffer"),
                new("Gartenkresse", 1, "Kästchen"),
                new("Zitronensaft", 1, "TL"),
                new("Cashewmus", 100, "g"),
                new("Muskatnuss"),
                new("Brokkoli", 600, "g"),
                new("Cashewkerne", 50, "g"),
                new("Radieschen", 1 / 2f, "Bund"),
                new("Zwiebel(n)", 1, "Bund")
            }),
            new Recipe("Grillkäse (Halloumi) mit Wassermelone", 20, 2, 30, new[] { Resources._20 }, "grillkaese_halloumi_mit_wassermelone_56017", new List<Ingredient>()
            {
                new("Halloumi", 500, "g"),
                new("Wassermelone", 550,"g"),
                new("Zwiebel(n)"),
                new("Bio-Limetten", 2),
                new("Olivenöl", 4, "EL"),
                new("Salz"),
                new("Pfeffer"),
                new("Honig", 1, "EL flüssiger"),
                new("Minze", 3, "Stiele")
            }),
            new Recipe("Haferflocken Burger mit Rote Bete und Walnüssen", 221, 2, 40, new[] { Resources._221 }, "Haferflocken_Burger_mit_Rote_Bete_und_Walnüssen", new List<Ingredient>()
            {
                new("Haferflocken", 120, "g feine"),
                new("Haferflocken", 80, "g grobe"),
                new("Leinsamen", 4, "EL geschrotet"),
                new("Rote Bete ", 2, "(Vakuumverpackt)"),
                new("Rote-Bete-Saft", 360, "ml"),
                new("Zwiebel(n)", 2, "rote"),
                new("Knoblauchzehen", 2),
                new("Rapsöl", 3, "EL"),
                new("Senfsamen", 2, "TL"),
                new("Koriandersamen", 2, "TL"),
                new("Paprikapulver edelsüß", 4, "TL"),
                new("Gemüsebrühe", 200, "ml"),
                new("Rucola", 6),
                new("Margarine", 2, "EL"),
                new("Sojasauce", 6, "EL"),
                new("Hefeflocken", 5, "EL"),
                new("Salz"),
                new("weißer Pfeffer"),
                new("Kurkuma", 1, "Prise"),
                new("Burgerbrötchen", 4),
                new("Ahornsirup", 2, "TL"),
                new("Walnusskernhälften", 20, "g"),
                new("Senf", 1, "TL")
            }),
            new Recipe("Pulled Jackfruit Burger mit Rotkohlsalat", 222, 2, 45, new[] { Resources._222 }, "Pulled_Jackfruit_Burger_mit_Rotkohlsalat", new List<Ingredient>()
            {
                new("Rotkohl", 500, "g"),
                new("Kokosblütenzucker", 1, "TL"),
                new("Weißweinessig", 1, "EL"),
                new("Walnussöl", 2, "EL"),
                new("Orangen", 125, "g kleine"),
                new("Jackfrucht", 280, "g"),
                new("Schalotte(n)", 2),
                new("Knoblauchzehe(n)", 2),
                new("Olivenöl", 1, "EL"),
                new("Barbecuesauce", 150, "g vegane"),
                new("Romanasalatblätter", 6),
                new("Avocado", 1 / 2),
                new("Burgerbrötchen", 3),
                new("Salz"),
                new("Pfeffer")
            }),
            new Recipe("Vegane Burger-Buns", 223, 3, 25, new[] { Resources._223 }, "Vegane_Burger_Buns", new List<Ingredient>()
            {
                new("Hefe", 63, "g"),
                new("Rohrohrzucker", 2, "EL"),
                new("Leinsamen", 4, "EL geschrotete"),
                new("Hafermilch", 200, "ml"),
                new("Rapsöl", 5, "EL"),
                new("Dinkelmehl Typ 630", 240, "g"),
                new("Weizen-Vollkornmehl", 160, "g"),
                new("Joghurt", 5, "EL"),
                new("Sojacreme", 3, "EL"),
                new("Salz", 2, "TL"),
                new("Pfeffer")
            }),
            new Recipe("Steakburger mit Rotkohl", 224, 1, 25, new[] { Resources._224 }, "Steakburger_mit_Rotkohl", new List<Ingredient>()
            {
                new("Rotkohl", 200, "g"),
                new("Zwiebel(n)", 2, "rote"),
                new("Rotweinessig", 3, "EL"),
                new("Honig", 2, "TL"),
                new("Rumpsteak ", 600, "g"),
                new("Olivenöl", 4, "EL"),
                new("Vollkornbrötchen", 4, "runde"),
                new("Salz"),
                new("Pfeffer")
            }),
            new Recipe("Vegane Süßkartoffel-Burger", 225, 3, 40, new[] { Resources._225 }, "Vegane_Süßkartoffel_Burger", new List<Ingredient>()
            {
                new("Süßkartoffel(n)", 200, "g"),
                new("Zwiebel(n)", 2, "rote"),
                new("Rotweinessig", 3, "EL"),
                new("Honig", 2, "TL"),
                new("Rumpsteak ", 600, "g"),
                new("Olivenöl", 4, "EL"),
                new("Vollkornbrötchen", 4, "runde"),
                new("Salz"),
                new("Pfeffer")
            }),
            new Recipe("Veganer Cheeseburger mit Black Bean Patty", 226, 3, 25, new[] { Resources._226 }, "Veganer_Cheeseburger_mit_Black_Bean_Patty", new List<Ingredient>()
            {
                new("Leinsamenschrot", 3, "EL"),
                new("Rote-Bete-Saft", 5, "EL"),
                new("Leinsamen", 4, "EL geschrotete"),
                new("Zwiebel(n)", 200, "g rote"),
                new("Knoblauchzehe(n)", 1),
                new("Champignons", 150, "g"),
                new("Olivenöl", 2, "EL"),
                new("Bohnen", 250, "g schwarze"),
                new("Haferflocken", 70, "g kernige"),
                new("Salz", 1, "TL"),
                new("Pfeffer"),
                new("Hefeflocken", 4, "TL"),
                new("Paprikapulver", 1, "TL (geräuchert)"),
                new("Kreuzkümmelpulver", 1, "TL"),
                new("Sojasauce", 3, "EL"),
                new("Eisbergsalat", 4, "blätter"),
                new("Tomate(n)", 1, "große"),
                new("Gewürzgurke", 100, "g"),
                new("Sesam-Burgerbrötchen", 4, "vegane"),
                new("Käsescheiben ", 4, "vegane"),
                new("Ketchup", 4, "EL"),
            }),
            new Recipe("Möhren-Sesam-Burger mit Avocado", 227, 2, 40, new[] { Resources._227 }, "Möhren_Sesam_Burger_mit_Avocado", new List<Ingredient>()
            {
                new("Möhren", 400, "g"),
                new("Ei(er)", 1),
                new("Semmelbrösel", 30, "g"),
                new("Tahini ", 1, "TL"),
                new("Kreuzkümmel", 1, "Prise gemahlener"),
                new("Koriander", 1, "Prise gemahlener"),
                new("Brötche(n)", 4, "helle"),
                new("Salatcreme", 30, "g"),
                new("Pflanzenöl ", 2, "EL"),
                new("Salz"),
                new("Pfeffer"),
                new("Zwiebel(n)", 1, "rote"),
                new("Rucola", 40, "g"),
                new("Mango-Chutney", 80, "g"),
            }),
            new Recipe("Spinat-Bacon-Burger mit Roter Bete", 228, 1, 30, new[] { Resources._228 }, "Spinat_Bacon_Burger_mit_Roter_Bet", new List<Ingredient>()
            {
                new("Rote Bete", 500, "g"),
                new("Pinienkerne", 2, "EL"),
                new("Baby-Spinat", 100, "g"),
                new("Olivenöl ", 3, "EL"),
                new("Parmesan", 1, "EL geriebener"),
                new("Salz"),
                new("Pfeffer"),
                new("Thymianblätter", 1, "TL frische"),
                new("Frühstücksspeck", 150, "g"),
                new("Brötche(n)", 4),
            }),
            new Recipe("Bagels mit Frischkäse und Avocado", 229, 1, 30, new[] { Resources._229 }, "Bagels_mit_Frischkäse_und_Avocado", new List<Ingredient>()
            {
                new("Bagels", 4),
                new("Kresse", 1),
                new("Zitronensaft", 2, "TL"),
                new("Avocado", 2),
                new("Cheddar-Käse", 100, "g"),
                new("Tomate(n)", 2),
                new("Salatgurke", 150, "g"),
                new("Schnittlauch", 1, "bund"),
                new("Doppelrahmfrischkäse ", 200, "g"),
                new("Salz"),
                new("Pfeffer"),
            }),
            new Recipe("Fisch-Burger", 230, 1, 25, new[] { Resources._230 }, "Fisch_Burger", new List<Ingredient>()
            {
                new("Blattsalat", 2),
                new("Tomate(n)", 3, "reife"),
                new("Zwiebel(n)", 2),
                new("Seelachsfilet", 480, "g"),
                new("Zitronensaft", 1, "EL"),
                new("Chiliflocken", 1, "Msp. getrocknete"),
                new("Olivenöl", 4, "EL"),
                new("Brötche(n)", 4),
                new("Mayonnaise", 4, "EL"),
                new("Dill", 1, "EL frischer")
            }),
            new Recipe("BBQ Pulled Sweet Potato Burger", 231, 3, 25, new[] { Resources._231 }, "BBQ_Pulled_Sweet_Potato_Burger", new List<Ingredient>()
            {
                new("Tomate(n)", 400, "ml (passiert)"),
                new("Knoblauch", 1, "zehe"),
                new("Olivenöl", 1, "TL"),
                new("Sojasauce", 2, "EL"),
                new("Reissirup", 1, "EL"),
                new("Paprikapulver ", 2, "TL (geräuchert)"),
                new("Garam Masala", 1, "TL"),
                new("Süßkartoffeln", 800, "g"),
                new("Zwiebel(n)", 1),
                new("Erdnussöl", 100, "ml"),
                new("Sojamilch", 100, "ml"),
                new("Senf", 1, "TL"),
                new("Apfelessig", 2, "EL"),
                new("Auberginen", 8),
                new("Brötche(n)", 4),
                new("Erdnussbutter", 6, "EL"),
                new("Erdnusskern", 4, "EL (gehackt)"),
            }),
            new Recipe("Sushi Burger", 232, 2, 20, new[] { Resources._232 }, "Sushi_Burger", new List<Ingredient>()
            {
                new("Sushi-Reis", 250, "g"),
                new("Gemüsebrühe", 375, "ml"),
                new("Reissirup", 2, "TL"),
                new("Limettensaft", 2, "EL"),
                new("Reisessig", 2, "EL"),
                new("Sesamöl ", 2, "EL"),
                new("Salatgurke", 1 / 4),
                new("Möhren", 1),
                new("Avocado", 1/2f),
                new("Wasabi", 1/2f , "TL"),
                new("Burgerbrötche(n)", 4),
                new("Sesam", 15, "g geröstet"),
                new("Wakame-Alge Salat", 130, "g"),
                new("Ingwer", 4, "TL"),
                new("Salz"),
            }),
            new Recipe("Tofu-Polenta-Burger", 233, 3, 20, new[] { Resources._233 }, "Tofu_Polenta_Burger", new List<Ingredient>()
            {
                new("Vollkornbrötche(n)", 4),
                new("Tofu", 400, "g"),
                new("Eiertomate", 4),
                new("Salatgurke", 1/2f),
                new("Lollo biondo", 4, "Blätter"),
                new("Vollkornmehl ", 1, "EL"),
                new("Maisgrieß", 2, "EL"),
                new("Vollkorn-Semmelbrösel", 2, "EL"),
                new("Petersilie", 1, "EL gehackte"),
                new("Pfeffer"),
                new("Öl", 2, "EL"),
                new("Ketchup", 2, "EL"),
                new("Salz"),
            }),
            new Recipe("African Burger", 234, 1, 60, new[] { Resources._234 }, "African_Burger", new List<Ingredient>()
            {
                new("Fleischwurst", 400, "g"),
                new("Brötche(n)", 4),
                new("Aprikosenchutney ", 200, "g"),
                new("Aprikosen", 4, "frische"),
                new("Macadamianüsse biondo", 100, "g"),
                new("Zwiebel(n)", 1, "rote"),
                new("Mayonnaise", 1, "EL"),
                new("Sonnenblumenöl", 1, "EL"),
                new("Currypulver", 1, "TL"),
                new("Kopfsalat", 1),
                new("Paprikaschote", 1),
                new("Pfeffer"),
                new("Zucker"),
                new("Koriander"),
                new("Salz"),
            }),
            new Recipe("Tofu-Burger mit Hummus", 235, 2, 30, new[] { Resources._235 }, "Tofu_Burger_mit_Hummus", new List<Ingredient>()
            {
                new("Zwiebel(n)", 1),
                new("Petersilie", 20, "g"),
                new("Parmesan", 40, "g"),
                new("Tofu", 300, "g"),
                new("Sojasauce", 2, "EL"),
                new("Ei(er)", 1),
                new("Sesam", 30, "g"),
                new("Vollkorn-Semmelbrösel", 20, "g"),
                new("Rapsöl", 1, "EL"),
                new("Weißweinessig", 1, "EL"),
                new("Senf", 1/2f, "TL"),
                new("Pfeffer"),
                new("Olivenöl", 1, "EL"),
                new("Walnussöl", 1, "EL"),
                new("Salz"),
                new("Tomate(n)", 1),
                new("Salat", 40, "g"),
                new("brötche(n) ", 4),
                new("Hummus", 80, "g"),
            }),
            new Recipe("Grünkern-Burger", 236, 2, 25, new[] { Resources._236 }, "Grünkern_Burger", new List<Ingredient>()
            {
                new("Schalotte(n)", 3),
                new("Butter", 3, "EL"),
                new("Grünkernschrot", 150, "g"),
                new("Gemüsebrühe", 500, "ml"),
                new("Gouda", 50, "g geriebener"),
                new("Petersilie", 20, "g"),
                new("Sojaquark", 100, "g"),
                new("Speisestärke", 1, "EL"),
                new("Ei(er)", 1),
                new("Eiweiß", 1),
                new("Zwiebel(n)", 1/2f),
                new("Pfeffer"),
                new("Tomate(n)", 1),
                new("Salatblätter", 2),
                new("brötche(n)", 4),
                new("Hummus", 80, "g"),
                new("Mayonnaise", 4, "TL"),
                new("Ketchup", 4, "TL"),
            }),
            new Recipe("Gemüse-Burger", 237, 2, 40, new[] { Resources._237 }, "Gemüse_Burger", new List<Ingredient>()
            {
                new("Aubergine(n)", 300, "g"),
                new("Kartoffeln", 300, "g"),
                new("Ei(er)", 1),
                new("Petersilie", 4, "EL gehackte"),
                new("Knoblauchzehe(n)", 1),
                new("Semmelbrösel", 3 , "EL"),
                new("Olivenöl", 4, "EL"),
                new("Salz", 1, "EL"),
                new("Feta", 120, "g"),
                new("Salatkopf", 1/4f),
                new("Chilischote", 1, "rote"),
                new("Pfeffer"),
                new("saure Sahne", 100, "g"),
                new("Brötche(n)", 4),
            }),
            new Recipe("Fischburger", 238, 1, 25, new[] { Resources._238 }, "Fischburger", new List<Ingredient>()
            {
                new("Lachsfillet", 400, "g"),
                new("Ei(er)", 1),
                new("Dill", 1, "EL"),
                new("Meerrettich", 1, "EL"),
                new("Weißbrotbrösel", 80, "g"),
                new("Semmelbrösel ", 3, "EL"),
                new("Olivenöl", 4, "EL"),
                new("Salz", 1, "EL"),
                new("Feta", 120, "g"),
                new("Salatkopf", 1/4f),
                new("Chilischote", 1, "rote"),
                new("Pfeffer"),
                new("saure Sahne", 100, "g"),
                new("Brötche(n)", 4),
            }),
            new Recipe("Pytt i panna", 21, 2, 35, new[] { Resources._21 }, "pytt_i_panna_664817", new List<Ingredient>()
            {
                new("Kartoffel(n)", 600, "g"),
                new("Rapsöl", 3, "EL"),
                new("Rote Bete", 250, "g"),
                new("Schalotte"),
                new("Salz"),
                new("Pfeffer"),
                new("Petersilie", 1 / 2f, "Bund"),
                new("Ei(er)", 4)
            }),
            new Recipe("Vegane Linsen-Pasta mit Pesto rosso und Rucola", 22, 3, 30, new[] { Resources._22 }, "vegane_linsen_pasta_mit_pesto_rosso_und_rucola_656528", new List<Ingredient>()
            {
                new("Pinienkerne", 50, "g"),
                new("Knoblauchzehe(n)", 2, "kleine"),
                new("getrocknete Tomate(n)", 125,"g (abgetropfte)"),
                new("Olivenöl", 4,"EL"),
                new("Balsamessig", 1,"TL"),
                new("Salz"),
                new("Pfeffer"),
                new("Rucola", 80, "g"),
                new("Basilikum", 10, "g"),
                new("Zwiebel(n)",1 ,"rote"),
                new("Cherrytomate(n)", 250, "g"),
                new("Linsennudeln", 250, "g")
            }),
            new Recipe("Frucht-Paprika-Kurkuma-Smoothie", 23, 3, 15, new[] { Resources._23 }, "frucht_paprika_kurkuma_smoothie_660269", new List<Ingredient>()
            {
                new("Mango", 150,"g Fruchtfleisch vom"),
                new("Papaya", 150,"g Fruchtfleisch vom"),
                new("Paprikaschote(n)",1, "gelbe"),
                new("Orange", 1,"Bio"),
                new("Limette",1,"Bio"),
                new("Kurkumapulver", 1,"TL"),
                new("Leinöl",1,"EL"),
                new("Hafermilch",300,"ml"),
                new("Heidelbeeren",100,"g"),
                new("Himbeeren", 100,"g")
            }),
            new Recipe("Gemüse-Linsen-Eintopf mit Erbsen", 24, 3, 25, new[] { Resources._24 }, "gemuese_linsen_eintopf_mit_erbsen_661997", new List<Ingredient>()
            {
                new("Ingwer", 5, "g"),
                new("Schalotte(n)"),
                new("Süßkartoffel(n)"),
                new("Knollensellerie", 100, "g"),
                new("Olivenöl", 2, "EL"),
                new("rote Linsen", 80, "g"),
                new("Harissa-Paste", 1, "TL"),
                new("Tomatenmark", 1, "EL"),
                new("Currypulver", 1 / 2f, "TL"),
                new("Gemüsebrühe", 600, "ml"),
                new("Salz"),
                new("Pfeffer"),
                new("Kokosmilch",4,"EL"),
                new("Zwiebel(n)", 2),
                new("Tiefkühlerbse(n)",150,"g"),
                new("Sonnenblumenkerne",2,"TL")
            }),
            new Recipe("Pasta mit grünem Spargel, Tomaten und Pinienkernen", 25, 3, 25, new[] { Resources._25 }, "pasta_mit_gruenem_spargel_tomaten_und_pinienkernen_42143_1", new List<Ingredient>()
            {
                new("Vollkorn Penne", 400, "g"),
                new("Jodsalz"),
                new("Spargel", 500, "g grüner"),
                new("Cocktailtomate(n)", 250, "g"),
                new("Pinienkerne", 40, "g"),
                new("Olivenöl", 4, "EL"),
                new("Pfeffer"),
                new("Basilikum", 20, "g")
            }),
            new Recipe("Bärlauch-Hummus", 26, 3, 15, new[] { Resources._26 }, "baerlauch_hummus_652693_1", new List<Ingredient>()
            {
                new("Kichererbsen", 225, "g"),
                new("Zitronensaft", 1, "EL"),
                new("Olivenöl", 1.5f, "EL"),
                new("Kreuzkümmel", 1 / 2f, "TL"),
                new("Salz", 1 / 4f, "TL"),
                new("Pfeffer", 1 / 4f, "TL"),
                new("Paprikapulver", 1 / 4f, "TL edelsüßes"),
                new("Bärlauch", 50, "g"),
                new("Chiliflocken", 1 / 4f, "TL")
            }),
            new Recipe("Süßkartoffelsalat", 27, 3, 15, new[] { Resources._27 }, "suesskartoffelsalat_650483", new List<Ingredient>()
            {
                new("Aubergine(n)", 2),
                new("Süßkartoffel(n)", 800, "g"),
                new("Zwiebel(n)"),
                new("Knoblauchzehe(n)"),
                new("Sesamöl", 4, "EL"),
                new("Koriander", 1 / 2f, "TL gemahlener"),
                new("Kreuzkümmel", 1 / 2f, "TL gemahlener"),
                new("Salz"),
                new("Pfeffer"),
                new("Cayennepfeffer", 1, "Prise"),
                new("Paprikaschote(n)", 300, "g kleine rote"),
                new("Ingwer", 20, "g"),
                new("Gemüsebrühe", 2, "EL"),
                new("Limettensaft", 2, "EL"),
                new("Sesam", 40, "g"),
                new("Chilliflocken", 2, "Msp"),
                new("Feldsalat", 100, "g")
            }),
            new Recipe("Nudeln mit veganer Spinat-Sahne-Soße (Rahmspinat)", 28, 3, 20, new[] { Resources._28 }, "Image_2021_07_10_10_45_13", new List<Ingredient>()
            {
                new("Blattspinat", 400, "g"),
                new("Öl", 1, "EL"),
                new("Zwiebel(n)", 1, "große"),
                new("Knoblauchzehe(n)", 4, "fein gehackte"),
                new("Hafer-Sahne", 250, "ml"),
                new("Pflanzenmilch", 100, "ml"),
                new("Cashewmehl", 2, "EL"),
                new("Hefeflocken", 2, "EL"),
                new("Gemüsebrühen-Pulver", 2, "TL"),
                new("Salz"),
                new("Pfeffer"),
                new("Muskat", 1, "Prise"),
                new("Nudeln", 350, "g")
            }),
            new Recipe("Das Beste Hummus Rezept", 29, 3, 8, new[] { Resources._29 }, "Image_2021_07_10_10_55_00", new List<Ingredient>()
            {
                new("Kichererbsen", 265, "g"),
                new("Tahini", 60, "g"),
                new("Knoblauch", 3, "Zehen"),
                new("Kreuzkümmel", 1 / 2f, "TL"),
                new("Salz", 1 / 2f, "TL"),
                new("Zitrone(n)", 1, "Saft von"),
                new("Wasser", 80, "ml"),
                new("Olivenöl", 2, "EL"),
                new("Paprikapulver"),
                new("Sesam"),
                new("Minze", 1, "optinonal")
            }),
            new Recipe("Veggie-Wraps mit Hummus", 30, 3, 25, new[] { Resources._30 }, "Image_2021_07_10_11_01_54", new List<Ingredient>()
            {
                new("Gemüse-Tortillas", 6),
                new("Hummus", 180, "g"),
                new("gemischter Salat", 6, "Handvoll"),
                new("Avocado"),
                new("Tomate(n)", 2),
                new("Gurke", 1 / 2f),
                new("Karotte(n)", 1, "große"),
                new("Paprika"),
                new("Hülsenfrüchte", 170, "g"),
                new("rote Zwiebel(n)"),
                new("Ketchup", 2, "EL")
            }),
            new Recipe("Rotes Thai-Curry (Vegan)", 31, 3, 30, new[] { Resources._31 }, "Image_2021_07_10_11_57_00", new List<Ingredient>()
            {
                new("Kokosöl", 2, "EL"),
                new("rote Zwiebel(n)", 2),
                new("Möhre(n)", 2),
                new("rote Paprika"),
                new("gelbe Paprika"),
                new("Brokkoli", 1, "Kopf"),
                new("Knoblauchzehe(n)", 3),
                new("Ingwer", 1, "EL"),
                new("Currypaste", 3, "EL rote"),
                new("Sojasauce", 3, "EL"),
                new("Paprikapulver", 2, "TL"),
                new("Reisessig", 2, "TL"),
                new("Kokosmilch", 600, "ml"),
                new("Gemüsebrühe", 120, "ml"),
                new("Erbsen", 1, "Tasse"),
                new("Babyspinat", 3, "Tassen frischer"),
                new("Kokosblütenzucker", 1, "EL")
            }),
            new Recipe("Veganes Spinat-Pilz-Risotto", 32, 3, 35, new[] { Resources._32 }, "Image_2021_07_10_12_13_40", new List<Ingredient>()
            {
                new("Arborio-Reis", 200, "g"),
                new("Olivenöl", 2, "EL"),
                new("Zwiebel(n)", 1, "große"),
                new("Knoblauchzehe(n)", 3),
                new("veganer Weißwein", 120, "ml"),
                new("Gemüsebrühe", 600, "ml"),
                new("Soja-Cuisine", 120, "ml"),
                new("Spinat", 150, "g"),
                new("Champignons", 200, "g"),
                new("Sojasauce", 3, "EL"),
                new("Salz"),
                new("Pfeffer")
            }),
            new Recipe("Zitronenspaghetti (Pasta al Limone)", 33, 3, 40, new[] { Resources._33 }, "Image_2021_07_10_12_21_16", new List<Ingredient>()
            {
                new("Olivenöl", 2, "EL"),
                new("Zwiebel(n)", 2, "mittelgroße"),
                new("Knoblauchzehe(n)", 5),
                new("Cashews", 150, "g"),
                new("Gemüsebrühe", 150, "g"),
                new("Hefeflocken", 4, "EL"),
                new("Zitrone(n)", 2),
                new("Salz"),
                new("Pfeffer"),
                new("Spaghetti", 350, "g"),
                new("Spargel", 1, "Bund"),
                new("frischer Spinat", 3, "Hände voll"),
                new("veganer Parmesan"),
                new("Pinienkerne", 1, "Hand voll geröstete")
            }),
            new Recipe("Die Besten Burger-Brötchen (Vegan)", 34, 3, 50, new[] { Resources._34 }, "Image_2021_07_10_12_32_51", new List<Ingredient>()
            {
                new("Sojamilch", 160, "ml"),
                new("Rohrzucker", 2, "EL"),
                new("Trockenhefe", 1, "Päckchen"),
                new("Weizenmehl", 500, "g"),
                new("Salz", 10, "g"),
                new("Wasser", 660, "ml"),
                new("Margarine", 75, "g"),
                new("Sojasahne", 4, "EL"),
                new("Kurkuma", 1, "Prise"),
                new("vegane Frikadellen", 2, "Packungen"),
                new("Öl", 60, "ml"),
                new("Salat"),
                new("Tomate(n)"),
                new("Zwiebel(n)"),
                new("Ketchup")
            }),
            new Recipe("Türkische Gözleme selber machen (Vegan)", 35, 3, 60, new[] { Resources._35 }, "Image_2021_07_10_12_44_54", new List<Ingredient>()
            {
                new("Aloo-Paratha Teig"),
                new("Sonnenblumen-Hack", 1, "Packung"),
                new("Gemüsebrühe", 240, "ml"),
                new("Olivenöl", 2, "EL"),
                new("Knoblauchzehe(n)", 3),
                new("rote Paprika"),
                new("Tomatenmark", 2, "EL"),
                new("Kreuzkümmel", 1 / 2f, "TL"),
                new("Paprikapulver", 1 / 2f, "TL"),
                new("Chili", 1 / 2f, "TL"),
                new("Salz"),
                new("Pfeffer"),
                new("Spinat", 60, "g grob gehackt"),
                new("Petersilie", 1 / 2f, "Bund"),
                new("veganer Feta", 120, "g"),
                new("veganer Reibekäse", 1, "Handvoll"),
            }),
            new Recipe("Knusprige Polenta-Pommes", 36, 3, 70, new[] { Resources._36 }, "Image_2021_07_10_12_54_05", new List<Ingredient>()
            {
                new("Gemüsebrühe", 960, "ml"),
                new("Polenta", 320, "g"),
                new("Margarine", 45, "g"),
                new("Knoblauchzehe(n)", 3),
                new("Rosmarin"),
                new("Thyamin"),
                new("Oregano"),
                new("Salz"),
                new("Pfeffer"),
                new("Haferflocken", 60, "g"),
                new("Hefeflocken", 4, "EL"),
                new("Paprikapulver", 2, "TL"),
                new("Olivenöl")
            }),
            new Recipe("Veganer Glutenfreier Dumpling- & Teigtaschen", 37, 3, 55, new[] { Resources._37 }, "Image_2021_07_10_13_02_08", new List<Ingredient>()
            {
                new("Reismehl", 200, "g helles"),
                new("Tapiokastärke", 80, "g"),
                new("Xanthan Gum", 2, "TL"),
                new("Salz", 1 / 2f, "TL"),
                new("Wasser", 180, "ml"),
                new("Öl", 1, "EL"),
                new("Dip")
            }),
            new Recipe("Das Beste Vegane Kartoffelpüree", 38, 3, 25, new[] { Resources._38 }, "Image_2021_07_10_13_13_17", new List<Ingredient>()
            {
                new("Kartoffel(n)", 1, "kg"),
                new("Olivenöl", 2, "TL"),
                new("Knoblauchzehe(n)", 4),
                new("Margarine", 3, "EL"),
                new("Pflanzenmilch", 120, "ml"),
                new("Salz", 1, "TL"),
                new("Pfeffer", 1, "schwarzer"),
                new("Petersilie"),
                new("Thymian"),
                new("Rosmarin"),
                new("Pinienkerne")
            }),
            new Recipe("Vegane Lasagne-Suppe", 39, 3, 30, new[] { Resources._39 }, "Image_2021_07_10_13_20_19", new List<Ingredient>()
            {
                new("Olivenöl", 2, "EL"),
                new("Zwiebel(n)", 2, "große"),
                new("Karotten(n)", 2),
                new("Sellerie", 2, "Stangen"),
                new("Knoblauch", 3, "Zehen"),
                new("Tomatenmark", 2, "EL"),
                new("Agavensirup", 2, "EL"),
                new("Sonnenblumen-Hack", 1, "Packung"),
                new("passierte Tomaten", 400, "g"),
                new("gestückelte Tomaten", 400, "g"),
                new("Gemüsebrühe", 750, "ml"),
                new("Paprikapulver", 1, "TL"),
                new("Oregano"),
                new("Basilikum"),
                new("Thymian"),
                new("Salz", 2 / 3f, "TL"),
                new("Pfeffer", 1 / 2f, "TL"),
                new("Lasagnenudeln", 250, "g"),
                new("Veganer Parmesan")
            }),
            new Recipe("Vegane Thai-Karottensuppe", 40, 3, 25, new[] { Resources._40 }, "Image_2021_07_10_13_31_32", new List<Ingredient>()
            {
                new("Olivenöl", 1, "EL"),
                new("Zwiebel(n)"),
                new("Knoblauchzehe(n)", 3),
                new("Ingwer", 25, "g"),
                new("Currypulver", 3, "TL"),
                new("Karotte(n)", 500, "g"),
                new("Kartoffel(n)", 120, "g"),
                new("Gemüsebrühe", 600, "ml"),
                new("Kokosmilch", 120, "ml"),
                new("Paprikapulver", 1, "TL rotes"),
                new("Chilipulver", 1 / 8f, "TL"),
                new("Salz"),
                new("Pfeffer"),
                new("Zitronensaft"),
                new("Cashewkerne", 100, "g rohe"),
                new("Kokosöl", 1, "TL"),
                new("Kokosraspeln"),
                new("Petersilie"),
                new("Koriander"),
                new("Limette(n)")
            }),
            new Recipe("Vegane Schupfnudeln mit Sauerkraut und Pilzen", 41, 3, 70, new[] { Resources._41 }, "Image_2021_07_10_13_57_14", new List<Ingredient>()
            {
                new("Kartoffel(n)", 900, "g mehlig"),
                new("Weizenmehl", 160, "g"),
                new("Kartoffelmehl", 30, "g"),
                new("Salz", 1, "TL"),
                new("Muskatnuss", 1, "Prise"),
                new("Rapsöl", 3, "EL"),
                new("Champignons", 500, "g"),
                new("Sojasauce", 2, "EL"),
                new("Zwiebel(n)", 2),
                new("Kümmel", 2, "TL"),
                new("Sauerkraut", 800, "g"),
                new("Pfeffer"),
                new("veganer Pamesan"),
                new("Petersilie"),
                new("Lauchzwiebel(n)")
            }),
            new Recipe("Vegane Himbeer-Mandel-Torte", 42, 3, 80, new[] { Resources._42 }, "Image_2021_07_10_14_08_02", new List<Ingredient>()
            {
                new("Weizenmehl", 360, "g"),
                new("Mandeln", 100, "g gemahlene blanchierte"),
                new("Backpulver", 2, "TL"),
                new("Natron", 1 / 2f, "TL"),
                new("Salz", 1 / 4f, "TL"),
                new("Zucker", 200, "g"),
                new("Zucker", 200, "g"),
                new("Pflanzenmilch", 320, "ml"),
                new("Orangensaft", 120, "ml"),
                new("Orange"),
                new("Apfel", 60, "g"),
                new("Öl", 120, "ml neutrales"),
                new("Vanilleextrakt", 2, "TL"),
                new("Himbeeren", 300, "g"),
                new("Zitrone"),
                new("Speisestärke", 1, "EL"),
                new("veganer Frischkäse", 300, "g"),
                new("Puderzucker", 60, "g")
            }),
            new Recipe("Schoko-Tassenkuchen", 43, 3, 15, new[] { Resources._43 }, "Image_2021_07_10_14_22_23", new List<Ingredient>()
            {
                new("Banane(n)", 1, "kleine zerdrückte"),
                new("Pflanzenmilch", 40, "ml"),
                new("Erdnussbutter", 1, "EL"),
                new("Weizenmehl", 50, "g"),
                new("Kakaopulver", 1, "EL"),
                new("Backpulver", 1 / 2f, "TL"),
                new("Zucker", 1, "EL"),
                new("Vanilleextrakt", 1 / 2f, "TL"),
                new("Kokosöl"),
                new("Schokolade"),
                new("Granola"),
                new("Himbeeren")
            }),
            new Recipe("Veganer Karottenkuchen", 44, 3, 100, new[] { Resources._44 }, "Image_2021_07_10_14_31_36", new List<Ingredient>()
            {
                new("Karotte(n)", 250, "g"),
                new("Margarine", 125, "g"),
                new("Zucker", 100, "g"),
                new("Salz", 1, "Prise"),
                new("Vanille", 1, "Prise (gemahlene)"),
                new("Leinsamen", 2, "Eier"),
                new("Zimt", 1 / 2f, "TL"),
                new("Mandeln", 100, "g"),
                new("Mehl", 125, "g"),
                new("Apfelessig", 1, "TL"),
                new("Backpulver", 1.5f, "TL"),
                new("Natron", 1 / 2f, "TL"),
                new("veganer Frischkäse", 200, "g"),
                new("Puderzucker", 80, "g"),
                new("Zitronensaft", 1, "Spritzer"),
                new("Vanille", 1, "etwas gemahlene"),
                new("Marzipan-Karotten"),
                new("Pistazien", 1, "gehackte")
            }),
            new Recipe("Veganer Streuselkuchen mit Käsekuchenschicht und Blaubeeren", 45, 3, 70, new[] { Resources._45 }, "Image_2021_07_10_14_45_09", new List<Ingredient>()
            {
                new("Dinkelmehl", 200, "g"),
                new("Mandeln", 50, "g"),
                new("Backpulver", 1 / 2f, "Packung"),
                new("Margarine", 175, "g"),
                new("Apfelmus", 50, "g"),
                new("Rohrzucker", 100, "g"),
                new("Zitrone(n)", 1 / 2f, "Schale und Saft"),
                new("Zimt", 1 / 2f, "TL"),
                new("Salz", 1, "Prise"),
                new("Sojamilch"),
                new("veganer Quark", 250, "g"),
                new("Kokosmilch", 50, "ml"),
                new("Speisestärke", 20, "g"),
                new("Blaubeeren", 250, "g")
            }),
            new Recipe("Kirsch-Kuchen mit saftiger Füllung (vegan + einfach)", 46, 3, 50, new[] { Resources._46 }, "Image_2021_07_10_14_56_48", new List<Ingredient>()
            {
                new("Weizenmehl", 150, "g"),
                new("Backpulver", 1 / 2f, "TL"),
                new("Margarine", 90, "g"),
                new("Apfelmus", 50, "g"),
                new("Rohrzucker", 50, "g"),
                new("Vanille", 1, "Msp"),
                new("Salz", 1, "Prise"),
                new("Kirschen", 350, "g"),
                new("Kirschsaft", 200, "ml"),
                new("Stärke", 25, "g")
            }),
            new Recipe("Bärlauch-Faltenbrot mit Kräuterbutter", 47, 3, 80, new[] { Resources._47 }, "Image_2021_07_10_15_06_28", new List<Ingredient>()
            {
                new("Dinkelmehl", 500, "g"),
                new("Trockenhefe", 1, "Pächkchen"),
                new("Salz", 2, "TL"),
                new("Wasser", 150, "ml"),
                new("Sojamilch", 100, "ml"),
                new("Olivenöl", 40, "ml"),
                new("Agavensirup", 1, "TL"),
                new("Bärlauch", 80, "g"),
                new("Margarine", 150, "g"),
                new("Pfeffer", 1 / 2f, "TL"),
                new("Hefeflocken", 2, "EL"),
                new("Kurkuma", 1, "Prise")
            }),
            new Recipe("Vegane Gnocchi", 48, 3, 35, new[] { Resources._48 }, "Image_2021_07_10_15_20_51", new List<Ingredient>()
            {
                new("Kartoffel(n)", 500, "g"),
                new("Weizenmehl", 150, "g"),
                new("Kartoffelmehl", 25, "g"),
                new("Salz", 1 / 2f, "TL"),
                new("Muskatnuss", 1, "Prise"),
                new("Mehl", 1, "zum Bestäuben etwas")
            }),
            new Recipe("Veganer Cashew Ricotta", 49, 3, 13, new[] { Resources._49 }, "Image_2021_07_10_15_25_36", new List<Ingredient>()
            {
                new("Cashewkerne", 250, "g"),
                new("Wasser", 80, "ml"),
                new("Hefeflocken", 3, "EL"),
                new("Knoblauchzehe(n)"),
                new("Zitronensaft", 2, "EL"),
                new("Salz"),
                new("Pfeffer"),
                new("Paprikapulver", 1, "Prise")
            }),
            new Recipe("Pasta mit cremiger Paprika Cashew Pesto Soße", 50, 3, 25, new[] { Resources._50 }, "Image_2021_07_10_15_32_35", new List<Ingredient>()
            {
                new("Nudeln", 250, "g Tortiglioni"),
                new("rote Paprika"),
                new("Zwiebel(n)"),
                new("Knoblauch", 2, "Zehen"),
                new("Chili", 1, "kleine Schote"),
                new("Öl", 2, "EL"),
                new("Cashewmus", 3, "EL"),
                new("Hefeflocken", 3, "EL"),
                new("Ajvar", 3, "EL"),
                new("Salz"),
                new("Pfeffer"),
                new("Zucker"),
                new("pflanzliche Milch"),
                new("Tomate(n)", 1, "paar (optional)"),
                new("Tomatenflocken"),
                new("Basilikum")
            }),
            new Recipe("Nudeln mit Hähnchen-Tomatensauce", 121, 1, 25, new[] { Resources._121 }, "nudeln_mit_haehnchen_tomatensauce_159745", new List<Ingredient>()
            { new("Nudeln z. B. Fusili", 300, "g"),
                new("Tomaten", 2),
                new("Tomatenmark", 1, "EL"),
                new("Frühstücksspeck", 500, "g"),
                new("Hähnchenbrustfilets", 2),
                new(" Schlagsahne", 200, "g"),
                new("Salz"),
                new("Pfeffer aus der Mühle"),
                new("Rucolablatt "),
            }),
            new Recipe("Hähnchen-Schnitzel mit Nudeln", 122, 1, 25, new[] { Resources._122 }, "haehnchen_schnitzel_mit_nudeln_197493", new List<Ingredient>()
            { new("Hähnchenbrustfilet (je 150- 4 Hähnchenbrustfilets)", 200, "g"),
                new("Mehl", 100, "g"),
                new("Salz"),
                new("Eier", 3),
                new(" Schlagsahne", 2, "EL"),
                new("Semmelbrösel"),
                new("neutrales Pflanzenöl", 1 / 4f, "l"),
                new("unbehandelte Zitrone in Spalten", 1),
                new("Nudeln (Linguine)", 500, "g"),
                new("Knoblauchzehe", 1),
                new("frisch gehackte Petersilie", 2, "EL"),
                new("Butter", 1, "EL"),
            }),
            new Recipe("Paprika-Rindfleischpfanne", 123, 1, 15, new[] { Resources._123 }, "paprika_rindfleischpfanne_448298", new List<Ingredient>()
            {
                new("Spitzpaprikaschoten (gelb und rot)", 6),
                new("rote Chilischote", 1),
                new("1 Zwiebel", 1),
                new(" Knoblauchzehe", 1),
                new(" Kirschtomaten", 200, "g"),
                new(" mageres Rindfleisch (z. B. Rumpsteak)", 800, "g"),
                new("Olivenöl", 3, "EL"),
                new("Tomatenmark (1 EL)", 20, "g"),
                new("edelsüßes Paprikapulver", 2, "EL"),
                new("Fleischbrühe", 750, "ml"),
                new("Salz"),
                new("Pfeffer "),
                new("gemahlener Koriander"),
                new("gemahlener Kümmel"),
                new("Petersilie (0.5 Bund)", 10, "g"),
                new("edelsüßes Paprikapulver", 2, "EL"),

            }),
            new Recipe("Seeteufel-Spinat-Päckchen", 124, 1, 45, new[] { Resources._124 }, "seeteufel_spinat_paeckchen_653619", new List<Ingredient>()
            {
                new("Spinat", 50, "g"),
                new("Salz"),
                new("Lauch", 2),
                new("große Möhren (2 große Möhren)", 300, "g"),
                new("Seeteufelfilet", 600, "g"),
                new("Bio-Zitrone", 1),
                new("Seelachsfilet", 300, "g"),
                new("Sojacreme", 100, "ml"),
                new("Hüttenkäse (0,3 % Fett)", 150, "g"),
                new("Pfeffer"),
                new("Fischfond (Glas)", 100, "ml"),
                new("gelbe oder rote Kirschtomaten", 250, "g"),
                new("Olivenöl", 1, "EL"),
                new("rote Ampfer- oder Mangoldblätter nach Belieben", 4),
                new("Schnittlauch (0.25 Bund)", 5, "g"),


            }),
            new Recipe("Lamm-Curry mit Pflaumen", 125, 1, 35, new[] { Resources._125 }, "lamm_curry_mit_pflaumen_668061", new List<Ingredient>()
            {
                new("Lammfleisch (aus der Keule)", 700, "g"),
                new("Möhren", 3),
                new("große Zwiebeln (200 g)", 2),
                new("Knoblauchzehen", 4),
                new("Ingwerwurzel", 30, "g"),
                new("rote Chilischote", 1),
                new("Ghee (45 g; alternativ Butterschmalz)", 3, "EL"),
                new("Gewürznelken", 3),
                new("grüne Kardamomkapseln", 4),
                new("Zimtstange", 1 / 2f),
                new("Fischfond (Glas)", 100, "ml"),
                new("Kurkumapulver", 1 / 2f, "TL"),
                new("Salz"),
                new("Lammfond (Glas)", 250, "ml"),
                new("Tomaten (480 g)", 6),
                new("Pflaumen", 6),
                new("Koriander (10 g)", 1 / 2f, "Bund"),

            }),
            new Recipe("Gemüse-Couscous mit Rinderfrikadellen", 126, 1, 20, new[] { Resources._126 }, "gemuese_couscous_mit_rinderfrikadellen_655599", new List<Ingredient>()
            {
                new(" Zwiebel(n)", 1),
                new("Rinderhackfleisch", 250, "g"),
                new("Ei", 1),
                new(" Haferflocken (2 EL)", 20, "g"),
                new("Salz "),
                new("Pfeffer"),
                new(" gemahlener Kreuzkümmel", 1 / 2f, "TL"),
                new("Paprikapulver", 1 / 4, "TL"),
                new("Olivenöl", 1 / 2f, "TL"),
                new("Zucchini", 1),
                new("Möhren", 2),
                new("Tomaten", 125, "g"),
                new("Couscous oder Bulgur", 100, "g"),
                new("Gemüsebrühe", 300, "ml"),
                new("Chiliflocken", 1, "Prise"),


            }),
            new Recipe("Gemüse-Couscous mit Hähnchen", 127, 1, 10, new[] { Resources._127 }, "gemuese_couscous_mit_haehnchen_39839", new List<Ingredient>()
            {
                new(" Hähnchenbrustfilets à ca. 140 g ", 2),
                new("Möhren", 2),
                new(" Erbsen", 200, "g"),
                new(" Geflügelbrühe", 600, "ml"),
                new(" Couscous Instant", 300, "g"),
                new("Salz"),


            }),
            new Recipe("Hirschgulasch mit Schokolade und Ofenmöhren", 128, 1, 260, new[] { Resources._128 }, "hirschgulasch_mit_schokolade_und_ofenmoehren_656927", new List<Ingredient>()
            {
                new("Möhren", 1, "kg"),
                new("Knollensellerie", 150, "g"),
                new("rote Zwiebeln(n)", 2),
                new(" Rapsöl", 4, "EL"),
                new("Hirschgulasch (in Würfel geschnitten; alternativ Rindfleisch)", 800, "g"),
                new(" Tomatenmark (2 EL)", 30, "g"),
                new(" Rotwein", 50, "ml"),
                new("Gemüsebrühe", 400, "ml"),
                new("Salz"),
                new("Pfeffer"),
                new("Wacholderbeere", 1, "TL"),
                new("Lorbeerblatt", 1),
                new("Cranberrys (tiefgekühlt)", 200, "g"),
                new("Waldhonig", 4, "EL"),
                new("gemahlener Kreuzkümmel", 1 / 2f, "TL"),
                new("Zartbitterschokolade (mind. 70 % Kakaoanteil)", 20, "g"),


            }),
            new Recipe("Spargel klassisch mit Entenbrust", 129, 1, 80, new[] { Resources._129 }, "spargel_klassisch_mit_entenbrust_660237", new List<Ingredient>()
            {
                new("weißer Spargel", 1, "kg"),
                new(" Butter", 115, "g"),
                new("Rohrohrzucker", 1, "TL"),
                new("Salz"),
                new("festkochende Kartoffeln", 500, "g"),
                new("Pfefferkörner", 3),
                new("Eier", 2),
                new("Pfeffer"),
                new("Paprikapulver edelsüß "),
                new("Muskatnuss"),
                new("Petersilie (20 g)", 1, "Bund"),

            }),
            new Recipe("Schweinefilet-Pfanne mit Gemüse", 130, 1, 30, new[] { Resources._130 }, "schweinefilet_pfanne_mit_gemuese_33385", new List<Ingredient>()
            {
                new("gelbe Paprikaschoten", 2),
                new(" Zuckerschoten", 150, "g"),
                new(" Möhren", 250, "g"),
                new("Champignons", 150, "g"),
                new("Pflanzenöl"),
                new("Orangensaft", 100, "ml"),
                new("Salz"),
                new("Pfeffer aus der Mühle"),
                new("Schweinelende küchenfertig", 600, "g"),
                new("helle Sesamsamen", 2, "EL"),
            }),
            new Recipe("Cottage Pie mit Fleisch und Gemüse gefüllt", 131, 1, 30, new[] { Resources._131 }, "cottage_pie_mit_fleisch_und_gemuese_gefuellt_33983", new List<Ingredient>()
            {
                new("mehligkochende Kartoffeln", 30, "g"),
                new(" Salz"),
                new(" Zwiebel(n)"),
                new("grüne Erbsen TK", 100, "g"),
                new("Möhre"),
                new("Tomate"),
                new(" Hackfleisch", 400, "g"),
                new(" Pflanzenöl", 2, "EL"),
                new("Tomatenmark", 1, "TL"),
                new("Salz"),
                new("Pfeffer aus der Mühle"),
                new("heiße Milch", 600, "ml"),
                new("weiche Butter", 20, "g"),
                new("geriebener Cheddar-Käse", 50, "g"),
                new("Muskat"),
                new("Blätterteig Fertigprodukt, Kühlregal", 1, "Rolle"),
                new(" Butter für Formen "),
            }),
            new Recipe("Gegrillte Schweinefilets mit Chili und Orange mariniert ", 132, 1, 30, new[] { Resources._132 }, "gegrillte_schweinefilets_5295", new List<Ingredient>()
            {
                new("Bio-Orange", 1),
                new("rote Chilischoten", 2),
                new("Limette", 1 / 2f),
                new("Öl + Öl für den Grill", 2, "EL"),
                new(" Tomatenmark", 2, "EL"),
                new("küchenfertige Schweinefilet (2 küchenfertige Schweinefilets)", 1200, "g"),

            }),
            new Recipe("Kalbsragout mit Kohlrabi", 133, 1, 90, new[] { Resources._133 }, "kalbsragout_kohlrabi_8089", new List<Ingredient>()
            {
                new("Schalotten", 250, "g"),
                new(" Kalbsgulasch", 800, "g"),
                new(" Dinkelmehl Type 630", 3, "EL"),
                new("Rapsöl", 3, "EL"),
                new("Salz"),
                new("Pfeffer "),
                new(" Weißwein", 50, "ml"),
                new("Geflügelfond", 500, "ml"),
                new("Bio-Zitrone", 1),
                new("Kohlrabi (2 Kohlrabi)", 600, "g"),
                new("Speisestärke", 1, "TL"),
                new("Kochsahne", 75, "ml"),
                new("Kerbel", 1, "Bund"),
                new("Honig", 50, "EL"),
            }),
            new Recipe("Schweinerückenbraten mit Apfel-Zwiebel-Gemüse", 134, 1, 30, new[] { Resources._134 }, "schweinerueckenbraten_5907", new List<Ingredient>()
            {
                new("Zwiebeln (4 Zwiebeln)", 200, "g"),
                new("saurer Äpfel (3 Äpfel)", 450, "g"),
                new("Fenchelsamen", 1, "TL"),
                new("schwarze Pfefferkörner", 6),
                new("körniger Senf", 1, "EL"),
                new("getrockneter Majoran ", 1, "TL"),
                new("magerer Schweinerücken", 800, "g"),
                new("Salz"),
                new("Rapsöl", 2, "EL"),
                new("trockener Cidre", 275, "ml"),
                new("Schlagsahne", 250, "ml"),
                new("Pfeffer"),

            }),
            new Recipe("Beef Wellington – smarter", 135, 1, 45, new[] { Resources._135 }, "beef_wellington_smarter_5921", new List<Ingredient>()
            {
                new("Thymian", 2, " Zweige"),
                new("Butter", 50, "g"),
                new("Filo-Teig (40 x 50 cm)", 2, "Blätter"),
                new("grob gestoßener, schwarzer Pfeffer "),
                new("Rinderfilet aus der Mitte", 900, "g"),
                new("Salz"),
                new("Olivenöl", 2, "EL"),
                new("Schalotten ", 3),
                new("Pilze (z.B. Shiitake, Champignons, Austernpilze)", 500, "g"),
                new("Petersilie", 4, "Stiele"),
                new("Kalbsfond", 325, "ml"),
                new("Balsamessig", 3, "EL"),
                new("grobes Meersalz "),

            }),
            new Recipe("Rouladen auf marokkanische Art", 136, 1, 45, new[] { Resources._136 }, "rouladen_marokkanische_art_5133", new List<Ingredient>()
            {
                new("gelbe Paprikaschote", 1),
                new("Sultaninen", 30, "g"),
                new("Mandelkerne (gehäutet)", 40, "g"),
                new("Tomatenmark ", 2, "EL"),
                new("Harissa", 1 / 2f, "TL"),
                new("große dünne Scheiben Rindfleisch (4 große dünne Scheiben Rindfleisch)", 800, "g"),
                new("Salz "),
                new("Zwiebeln(n)", 3),
                new("Knoblauchzehen)", 2),
                new("Mehl", 2, "EL"),
                new("Öl", 2, "EL"),
                new("Dosentomaten", 425, "g"),
                new("trockener Sherry", 225, "ml"),
                new("schwarzer Pfeffer"),

            }),
            new Recipe("Geschmorte Lammhaxen – smarter", 137, 1, 45, new[] { Resources._137 }, "geschmorte_lammhaxen_smarter_5891", new List<Ingredient>()
            {
                new("Suppengrün", 1, "Bund"),
                new("Lammhaxe (6 Lammhaxen)", 2400, "g"),
                new("Salz "),
                new("Pfeffer "),
                new("Olivenöl", 3, "EL"),
                new("Tomatenmark ", 2, "EL"),
                new("Rotwein", 500, "ml"),
                new("Lorbeerblätter", 2),
                new("klassische Gemüsebrühe", 600, "ml"),
                new("Salbei", 3, "Stiele"),
                new("Petersilie", 3, "Stiele"),
                new("Knoblauchzehe (nach Belieben auch mehr)"),
                new("Bio-Zitrone"),

            }),
            new Recipe("Kalbsschnitzel à la Saltimbocca", 138, 1, 25, new[] { Resources._138 }, "kalbsschnitzel_a_la_saltimbocca_7937", new List<Ingredient>()
            {
                new("Zucchini", 100, " g "),
                new("Schalotte", 1),
                new("Salbeiblätter", 8),
                new("Kalbsschnitzel", 320, " g"),
                new("Salz"),
                new("Pfeffer"),
                new("dünne Scheiben Parmaschinken (4 dünne Scheiben Parmaschinken)", 60, "g"),
                new("Orange", 1 / 2f),
                new("Olivenöl", 2, "EL"),
                new("klassische Gemüsebrühe", 2, "EL"),


            }),
            new Recipe("Tandoori-Lammgeschnetzeltes", 139, 1, 20, new[] { Resources._139 }, "tandoori_lammgeschnetzeltes_6153", new List<Ingredient>()
            {
                new("Lammrückenfilet", 350, " g "),
                new("Tandoori-Gewürzmischung", 1, "EL"),
                new("kleine rote Zwiebeln", 2),
                new("gelbe Paprikaschote (1 gelbe Paprikaschote)", 200, " g"),
                new("frische Ananas", 150, "g"),
                new("Öl", 1, "EL"),
                new("klassische Gemüsebrühe", 100, "ml"),
                new("Kokosmilch (9 % Fett)", 20, "ml"),
                new("Salz "),
                new("Pfeffer"),

            }),
            new Recipe("Kalbsrahmgulasch – smarter", 140, 1, 50, new[] { Resources._140 }, "kalbsrahmgulasch_smarter_5577", new List<Ingredient>()
            {
                new("Zwiebel(n)", 350, " g "),
                new("Kalbfleisch aus der Hüfte", 750, "g"),
                new("Rapsöl", 3, "EL"),
                new("Pfeffer"),
                new("Paprikapulver (edelsüß)", 2, "EL"),
                new("Vollkornmehl", 1, "EL"),
                new("Weißwein oder heller Traubensaft", 100, "ml"),
                new("Kalbsfond (Glas) oder Gemüsebrühe", 200, "ml"),
                new("Salz"),
                new("Lorbeerblätter", 2),
                new("festkochende Kartoffeln (6 festkochende Kartoffeln)", 300, "g"),
                new("Sauerkraut (Dose)", 425, "g"),
                new("Bio-Zitrone"),
                new("Sojacreme", 150, "ml"),
                new("Petersilie", 1, "Bund"),


            }),
            new Recipe("Überbackene Kalbsschnitzel mit Aubergine und Mozzarella ", 141, 1, 30, new[] { Resources._141 }, "ueberbackene_kalbsschnitzel_5599", new List<Ingredient>()
            {
                new("Auberginen (1 Aubergine)", 300, " g "),
                new("Büffelmozzarella", 175, "g"),
                new("Olivenöl", 3, "EL"),
                new("Pfeffer"),
                new("Tomaten", 2),
                new("Kalbsschnitzel (6 Kalbsschnitzel)", 900, "g"),
                new("Basilikum", 2, "Stiele"),
                new("Salz "),

            }),
            new Recipe("Steaks vom Salzbett mit Süßkartoffeln und Gemüse  ", 142, 1, 30, new[] { Resources._142 }, "steaks_salzbett_5629", new List<Ingredient>()
            {
                new("grobes Meersalz", 750, " g "),
                new("Limettenblätter", 4),
                new("Süßkartoffeln (2 Süßkartoffeln)", 800, "g"),
                new(" kleine Zucchini (1 kleine Zucchini)", 150, "g"),
                new("gelbe Paprikaschote (1 gelbe Paprikaschote)", 200, "g"),
                new("Koriander", 5, "Stiele"),
                new("Reisessig", 1, "EL"),
                new("mildes Currypulver", 1, "EL"),
                new(" klassische Gemüsebrühe", 3, "EL"),
                new("Salz"),
                new("Pfeffer"),
                new("flüssiger Honig", 1, "TL"),
                new("Olivenöl", 4, "EL"),
                new("Rumpsteak (2 Rumpsteaks)", 550, "g"),


            }),
            new Recipe("Rindfleisch aus dem Wok mit Gemüse und Orange   ", 143, 1, 40, new[] { Resources._143 }, "rindfleisch_wok_5617", new List<Ingredient>()
            {
                new("kleine Bio-Orange", 1),
                new(" Maiskölbchen", 100, "g"),
                new("rote Paprikaschote (1 rote Paprikaschote)", 200, "g"),
                new("Möhren (1 Möhre)", 100, "g"),
                new(" Zuckerschoten", 75, "g"),
                new("schieres Rindfleisch (z.B. Rumpsteak)", 225, "g"),
                new("Ingwer (1 Stück)", 20, "g"),
                new("Knoblauchzehe", 1),
                new("rote Chilischoten", 2),
                new("Öl", 2, "EL"),
                new("Salz nach Belieben"),
                new("Pfeffer"),
                new("flüssiger Honig", 1, "TL"),
                new(" Hoisin-Sauce)", 4, "EL"),


            }),
            new Recipe("Kalbsfilet sizilianische Art Kalbsfilet sizilianische Art ", 144, 1, 30, new[] { Resources._144 }, "kalbsfilet_sizilianische_art_5567", new List<Ingredient>()
            {
                new("Orange", 2),
                new("rosa Grapefruit", 1),
                new("rote Zwiebel", 1),
                new(" Fenchel", 1, "Knolle "),
                new("Pistazien", 25, "g"),
                new("Zitrone", 1 / 2f),
                new(" Kalbsfilet (6 Kalbsfilets)", 300, "g"),
                new("Zweige Rosmarin", 2),
                new(" Olivenöl", 4, "EL"),
                new("Salz"),
                new("Pfeffer"),

            }),
            new Recipe("Wiener Schnitzel – smarter mit geriebenem Meerrettich  ", 145, 1, 15, new[] { Resources._145 }, "meerrettich_schnitzel_4935_1", new List<Ingredient>()
            {
                new("Kalbsschnitzel (4 Kalbsschnitzel)", 280, "g"),
                new("Ei", 1),
                new("Milch (1,5 % Fett)", 1, "EL"),
                new("Vollkorn-Semmelbrösel", 4, "EL"),
                new(" Weizenmehl Type 1050 (2 EL)", 30, "g"),
                new("geriebener Meerrettich (Glas)", 1, "EL"),
                new("Rapsöl", 2, "EL"),
                new("Salz"),
                new("Pfeffer"),
                new("Bio-Zitrone", 1 / 2f),

            }),
            new Recipe("Rinderfilet im Kräutergewürzmantel mit Rote-Bete-Gemüse  ", 146, 1, 35, new[] { Resources._146 }, "rinderfilet_kraeutergewuerzmantel_5631", new List<Ingredient>()
            {
                new("Knollen frische Rote Bete (2 Knollen frische Rote Bete)", 250, "g"),
                new(" Kümmel", 1, "TL"),
                new("Fenchelsamen", 1, "TL"),
                new(" Koriandersamen", 1, "TL"),
                new(" Rinderfilet (aus der Mitte)", 400, "g"),
                new("Olivenöl", 1, "EL"),
                new("Schalotten", 2),
                new("Butter", 20, "g"),
                new("Weißwein oder Brühe", 100, "ml"),
                new("Salz"),
                new("Pfeffer"),
                new("Zitrone", 1 / 2f),
                new("Schnittlauch", 1, "Bund"),


            }),
            new Recipe("Kalbsschnitzel in Granatapfelsauce mit roten Zwiebeln und Sultaninen  ", 147, 1, 25, new[] { Resources._147 }, "kalbsschnitzel_granatapfelsauce_5595", new List<Ingredient>()
            {
                new("Sultaninen", 2, "EL"),
                new(" Granatapfelsaft", 100, "ml"),
                new("rote Zwiebeln", 3),
                new(" Petersilie", 3, "Stiele "),
                new(" Kalbsschnitzel (6 Kalbsschnitzel)", 300, "g"),
                new("Olivenöl", 2, "EL"),
                new("Salz"),
                new("Pfeffer"),
                new("Zitrone", 1 / 2f),
                new("dunkler Kalbsfond", 150, "ml"),


            }),
            new Recipe("Orangen-Lachs mit Nussreis  ", 148, 1, 20, new[] { Resources._148 }, "orangen_lachs_mit_nussreis_448768_1", new List<Ingredient>()
            {
                new(" Basmati-Vollkornreis", 250, "g"),
                new("Bio-Orange", 1),
                new("Kräuter (1 Handvoll; Petersilie und Dill)", 40, "g"),
                new("Lachsfilet (4 Lachsfilets)", 600, "g"),
                new("Olivenöl", 5, "EL"),
                new("Salz"),
                new("Pfeffer"),
                new(" gesalzene Cashewkerne", 50, "g"),


            }),
            new Recipe("Spinat-Käse-Omelett mit Lachs ", 149, 1, 20, new[] { Resources._149 }, "kaeseomelett_mit_lachs_35281", new List<Ingredient>()
            {
                new("kleine Zwiebel(n)", 1),
                new("Spinat", 200, "g"),
                new("Mozzarella", 200, "g"),
                new("Lachsfilet", 200, "g"),
                new("Eier", 5),
                new("Salz"),
                new("Pfeffer"),
                new(" Milch", 2, "EL"),
                new("Butter", 2, "TL"),


            }),
            new Recipe("Joghurteis mit Schokotropfen", 150, 1, 30, new[] { Resources._150 }, "joghurteis_mit_schokotropfen_117265", new List<Ingredient>()
            {
                new("Naturjoghurt", 500, "g"),
                new("flüssiger Honig", 3, "EL"),
                new("Vanillezucker", 2, "EL"),
                new("Schlagsahne", 150, "ml"),

            }),
            new Recipe("Joghurteis mit Blaubeeren", 151, 1, 20, new[] { Resources._151 }, "joghurteis_mit_blaubeeren_321893", new List<Ingredient>()
            {
                new("Heidelbeeren", 300, "g"),
                new(" Honig", 30, "g"),
                new("Zitronensaft", 1, "EL"),
                new("Joghurt (1,5 % Fett)", 300, "g"),
                new("Sahnequark", 150, "g"),

            }),
            new Recipe("Himbeer-Joghurt-Eis", 152, 1, 15, new[] { Resources._152 }, "himbeer_joghurt_eis_9025", new List<Ingredient>()
            {
                new("Zitronenmelisse", 1, "Stiel"),
                new(" Puderzucker", 1, "EL"),
                new(" Zitrone ", 1 / 2f),
                new("tiefgekühlte Himbeeren", 150, "g"),
                new("    100 g Joghurt (1,5 % Fett; gut gekühlt) ", 100, "g"),

            }),
            new Recipe("Frozen Joghurt mit Himbeeren", 153, 1, 15, new[] { Resources._153 }, "frozen_joghurt_mit_himbeeren_448530", new List<Ingredient>()
            {
                new(" Himbeeren", 300, "g"),
                new("Honig", 2, "EL"),
                new("Zitronensaft", 2, "EL"),
                new("Schlagsahne", 50, "ml"),
                new("Joghurt (1,5 % Fett) ", 400, "g"),

            }),
            new Recipe("Leichtes Joghurteis mit Honig", 154, 1, 30, new[] { Resources._154 }, "leichtes_joghurteis_mit_honig_38181", new List<Ingredient>()
            {
                new("Walnüsse", 100, "g"),
                new("Honig", 3, "EL"),
                new("griechischer Joghurt", 500, "g"),
                new("Zitronensaft", 1, "EL"),
                new("Puderzucker aus Rohrohrzucker", 1, "EL"),
                new(" Schlagsahne mindestens 30 % Fettgehalt", 150, "ml"),
            }),
            new Recipe("Joghurt-Brombeer-Parfait", 155, 1, 15, new[] { Resources._155 }, "jighurt_brombeer_parfait_41785", new List<Ingredient>()
            {
                new("frische Brombeere", 500, "g"),
                new(" Zucker", 4, "EL"),
                new("Naturjoghurt", 250, "g"),
                new("geschlagene Schlagsahne", 100, "g"),
                new("gemahlener Zimt", 1, "Msp"),

            }),
            new Recipe("Joghurteis mit Beeren", 156, 1, 25, new[] { Resources._156 }, "joghurteis_mit_beeren_322641", new List<Ingredient>()
            {
                new("frische Beeren Him-, Erd-, Heidel- und Brombeeren", 300, "g"),
                new("Zitronensaft", 2, "EL"),
                new("Joghurt", 500, "g"),
                new(" Puderzucker", 40, "g"),
                new("Schlagsahne", 150, "ml"),

            }),
            new Recipe("Holunderblüten-Joghurt-Eis mit Zitronenmelisse ", 157, 1, 45, new[] { Resources._157 }, "holunderblueten_joghurt_eis_8783", new List<Ingredient>()
            {
                new("Holunderblütendolden", 6),
                new("Limette", 1),
                new("Apfelsaft", 50, "ml"),
                new("flüssiger Honig", 3, "EL"),
                new("Joghurt (1,5 % Fett)", 300, "g"),
                new("Kochsahne (15 % Fett)", 150, "ml"),
                new("weiße Gelatine", 1, "Blatt"),
                new("Zitronenmelisse", 2, "Stiele"),


            }),
            new Recipe("Low-Carb-Pancakes mit Banane", 158, 1, 10, new[] { Resources._158 }, "low_carb_pancakes_mit_banane_504119_1", new List<Ingredient>()
            {
                new(" große Bananen (1 große Banane)", 110, "g"),
                new(" Mandelmehl (5 EL)", 50, "g"),
                new("Eier (Größe M)", 2),
                new("Weinstein-Backpulver", 1, "TL"),
                new("Rapsöl", 2, "TL"),
                new("Brombeere", 50, "g"),
                new("Joghurt (3,5 % Fett)", 100, "g"),
                new("Minze"),

            }),
            new Recipe("Labneh", 159, 1, 10, new[] { Resources._159 }, "labneh_670163", new List<Ingredient>()
            {
                new("griechischer Joghurt (10 % Fett)", 500, "g"),
                new("Salz "),
                new("Olivenöl", 2, "EL"),
                new("Zatar (orientalische Gewürzmischung)", 1 / 2, "TL"),

            }),
            new Recipe("Spareribs vom Grill ", 160, 1, 15, new[] { Resources._160 }, "spareribs_vom_grill_107535", new List<Ingredient>()
            {
                new("magere Schweinerippe", 2, "Kg"),
                new("Knoblauchzehen", 3),
                new(" Olivenöl", 125, "ml"),
                new(" Ketchup", 2, "EL"),
                new("Salz"),
                new("frische Rosmarinzweige", 4),

            }),
            new Recipe("Kurzrippensteak vom Grill ", 161, 1, 20, new[] { Resources._161 }, "kurzrippensteak_vom_grill_39989", new List<Ingredient>()
            {
                new("Rinderfiletsteaks aus der Hochrippe, à 150 g", 4),
                new("Salz "),
                new("Olivenöl extra vergine "),
                new(" Pfeffer frisch gemahlen"),

            }),
            new Recipe("Speck-Zucchini-Röllchen mit Feta-Füllung ", 162, 1, 20, new[] { Resources._162 }, "speck_zucchini_roellchen_mit_feta_fuellung_110115", new List<Ingredient>()
            {
                new("Zucchini", 1),
                new("Salz "),
                new("Olivenöl ", 2, "EL"),
                new(" Pinienkerne", 20, "g"),
                new("Feta", 1, "TL"),
                new("Kräuter (Thymian und Rosmarin)", 1 / 2, "Bund"),
                new("geräucherter Bauchspeck", 20, "g"),

            }),
            new Recipe("Hähnchenschlegel vom Grill mit Kräuterbutter  ", 163, 1, 35, new[] { Resources._163 }, "haehnchenschlegel_vom_grill_mit_kraeuterbutter_37083", new List<Ingredient>()
            {
                new("Hähnchenkeulen", 12),
                new("rote Chilischote", 1),
                new("Knoblauchzehe", 1),
                new("Sesamsamen", 1, "EL"),
                new(" frisch gehackter Rosmarin", 1, "TL"),
                new("Ketchup", 1, "EL"),
                new("Honig", 1, "EL"),
                new("Zitronensaft", 2, "EL"),
                new("Sesamöl", 4, "EL"),
                new("Salz"),



            }),
            new Recipe("Hähnchenfleisch-Würstchen-Spiesse mit Gemüse  ", 164, 1, 30, new[] { Resources._164 }, "haehnchenfleisch_wuerstchen_spiesse_mit_gemuese_35143", new List<Ingredient>()
            {
                new("Hähnchenbrustfilet (2 Hähnchenbrustfilets)", 300, "g"),
                new("Sojasauce", 1, "EL"),
                new("grobe Wild- Bratwürste", 2),
                new("rote Paprikaschote", 1),
                new("grüne Paprikaschote", 1),
                new("Salbeiblatt", 1, "Bund"),
                new("Scheiben Vollkorntoast", 3),
                new("Parboiled Reis", 250, "g"),
                new("Olivenöll", 4, "EL"),
                new("Salz"),
                new("Pfeffer"),
                new("Zitrone,1"),



            }),
            new Recipe("Lammkeule vom Grill ", 165, 1, 40, new[] { Resources._165 }, "lammkeule_vom_grill_32359", new List<Ingredient>()
            {
                new("Lammkeule ca. 1,5 kg, küchenfertig ohne Knochen", 1),
                new("Knoblauchzehen", 2),
                new("Joghurt", 4, "EL"),
                new("gehackter Thymian", 2, "EL"),
                new("gehackter Rosmarin", 2, "EL"),
                new("Salz"),
                new("Pfeffer aus der Mühle"),




            }),
            new Recipe("Gegrillte Zitronen-Kartoffeln ", 166, 1, 30, new[] { Resources._166 }, "gegrillte_zitronen_kartoffeln_36543", new List<Ingredient>()
            {
                new("kleine Kartoffeln", 800, "g"),
                new("Knoblauchzehen", 3),
                new("Bio-Zitrone", 1),
                new(" Olivenöl", 4, "EL"),
                new("Salz"),
                new("Pfeffer aus der Mühle"),




            }),
            new Recipe("Forellen vom Grill ", 167, 1, 20, new[] { Resources._167 }, "forellen_vom_grill_42191", new List<Ingredient>()
            {
                new("Forelle (4 ganze, küchenfertige Forellen à ca. 350 g)", 1400, "g"),
                new("frische Petersilie", 50,"g"),
                new("Bio-Zitrone", 3),
                new("Salz"),
                new("Pfeffer aus der Mühle"),




            }),
            new Recipe("Biskuitteig mit Dinkelmehl", 168, 1, 25, new[] { Resources._168}, "biskuitteig_dinkelmehl_8863", new List<Ingredient>()
            {
                new("Eier (Größe M)", 4),
                new(" Rohrohrzucker", 80,"g"),
                new("Dinkelmehl Type 630",  150,"g"),
                new("Salz",1,"Prise"),

            }),
            new Recipe("Kürbiskekse", 169, 3, 20, new[] { Resources._169}, "kuerbiskekse_668323", new List<Ingredient>()
            {
                new(" vegane Zartbitterschokolade", 50,"g"),
                new("  Kokosöl", 60,"g"),
                new(" Vollrohrzucker",  80,"g"),
                new("Salz",1,"Prise"),
                new("Dinkelmehl Type 1050", 220,"g"),
                new("Backpulver", 1,"TL"),
                new(" Zimt", 1/2f,"TL"),
                new(" gemahlener Kardamom", 1," Msp."),
                new("gemahlene Muskatnuss", 1," Msp."),
                new("Kürbispüree", 120,"g"),
            }),
            new Recipe("Tortellini-Auflauf mit Schinken und Frühlingszwiebeln", 170, 1, 15, new[] { Resources._170 }, "tortellini_auflauf_mit_schinken_und_fruehlingszwiebeln_454276", new List<Ingredient>()
            {
                new(" Champignons", 150,"g"),
                new(" Putenschinken", 100,"g"),
                new("Frühlingszwiebeln",2),
                new("Salz"),
                new("Olivenöl",1,"EL"),
                new("Tortellini (Kühlregal)", 400,"g"),
                new(" Parmesan (1 Stück)",60,"g"),
                new("Milch (3,5 % Fett)", 100,"ml"),
                new("Ei", 1),
                new("Muskatnuss"),
                new("Pfeffer "),

               new(" Vollkorn-Semmelbrösel", 1,"EL"),
            }),
        };

        // Gibt alle Namen der Zutaten aus. Die Methode wird vor allem vom Autotext Expander verwendet.
        public string[] AllIngredientNames()
        {
            int zähler = 0;
            int ingredientCount = 0;
            foreach (Recipe recipe in AllRecipes)
            {
                ingredientCount += recipe.IngredientList.Count;
            }
            string[] allIngredientNames = new string[ingredientCount];
            foreach (Recipe recipe in AllRecipes)
            {
                foreach (Ingredient ingredient in recipe.IngredientList)
                {
                    allIngredientNames[zähler] = ingredient.Name;
                    zähler++;
                }
            }
            return allIngredientNames;
        }

        // Diese Methode prüft, ob die angegebene
        public Ingredient FindIngredient(string texteingabe)
        {
            foreach (Recipe recipe in AllRecipes)
            {
                foreach (Ingredient ingredient in recipe.IngredientList)
                {
                    if (ingredient.Name.ToLower() == texteingabe)
                    {
                        return new Ingredient(ingredient.Name);
                    }
                }
            }
            return null;
        }

        // Kann im Nachhinein wird das Hinzufügen bzw. Löschen von Rezepten verwendet werden.
        public List<Recipe> UpdateRecipes(List<Recipe> allRecipes)
        {
            return null;
        }
    }

}