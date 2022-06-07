using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CommonInterfaces;

namespace GUI
{
    public partial class StockForm : Form
    {
        public static StockForm stockForm = new StockForm();
        public StockForm()
        {
            InitializeComponent();
        }

        private void StockForm_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Fügt je nach gechekter Checkbox Zutaten zum IngredientAvailable hinzu
        /// </summary>
        public void SaveValues()
        {
            if (CheckBox_Zwiebeln.Checked)
            {
                AddIngredient("Zwiebel(n)");
                AddIngredient("rote Zwiebel(n)");
                AddIngredient("Schalotte(n)");
            }
            else
            {
                RemoveIngredient("Zwiebel(n)");
                RemoveIngredient("rote Zwiebel(n)");
                RemoveIngredient("Schalotte(n)");
            }

            if (CheckBox_Knoblauch.Checked)
            {
                AddIngredient("Knoblauch");
                AddIngredient("Knoblauchzehe(n)");
            }
            else
            {
                RemoveIngredient("Knoblauch");
                RemoveIngredient("Knoblauchzehe(n)");
            }

            if (CheckBox_Kartoffeln.Checked)
            {
                AddIngredient("Kartoffel(n)");
                AddIngredient("Süßkartoffel(n)");
            }
            else
            {
                RemoveIngredient("Kartoffel(n)");
                RemoveIngredient("Süßkartoffel(n)");
            }

            if (CheckBox_Tomaten.Checked)
            {
                AddIngredient("Tomate(n)");
                AddIngredient("Cherrytomate(n)");
            }
            else
            {
                RemoveIngredient("Tomate(n)");
                RemoveIngredient("Cherrytomate(n)");
            }

            if (CheckBox_Karotten.Checked)
            {
                AddIngredient("Karotte(n)");
                AddIngredient("Möhre(n)");
            }
            else
            {
                RemoveIngredient("Karotte(n)");
                RemoveIngredient("Möhre(n)");
            }

            if (CheckBox_Zuccini.Checked)
            {
                AddIngredient("Zucchini");
            }
            else
            {
                RemoveIngredient("Zucchini");
            }

            if (checkBox_ingwer.Checked)
            {
                AddIngredient("Ingwer");

            }
            else
            {
                RemoveIngredient("Ingwer");
            }

            if (CheckBox_Paprika.Checked)
            {
                AddIngredient("Paprika");
                AddIngredient("rote Paprika");
                AddIngredient("gelbe Paprika");
                AddIngredient("grüne Paprika");
            }
            else
            {
                RemoveIngredient("Paprika");
                RemoveIngredient("rote Paprika");
                RemoveIngredient("gelbe Paprika");
                RemoveIngredient("grüne Paprika");
            }

            if (CheckBox_Aubergine.Checked)
            {
                AddIngredient("Aubergine(n)");
            }
            else
            {
                RemoveIngredient("Aubergine(n)");
            }

            if (CHeckBox_Nudeln.Checked)
            {
                AddIngredient("Nudeln");
                AddIngredient("Vollkorn Nudeln");
                AddIngredient("Penne");
                AddIngredient("Vollkorn Penne");
                AddIngredient("Spaghetti");
                AddIngredient("Fusili Nudeln");
            }
            else
            {
                RemoveIngredient("Nudeln");
                RemoveIngredient("Spaghetti");
                RemoveIngredient("Fusili Nudeln");
                RemoveIngredient("Vollkorn Nudeln");
                RemoveIngredient("Penne");
                RemoveIngredient("Vollkorn Penne");
            }

            if (CheckBox_Reis.Checked)
            {
                AddIngredient("Reis");
                AddIngredient("Basmatireis");
            }
            else
            {
                RemoveIngredient("Reis");
                RemoveIngredient("Basmatireis");
            }

            if (CheckBox_Haferflocken.Checked)
            {
                AddIngredient("Haferflocken");
            }
            else
            {
                RemoveIngredient("Haferflocken");
            }

            if (CheckBox_Quinoa.Checked)
            {
                AddIngredient("Quiona");
            }
            else
            {
                RemoveIngredient("Quinoa");
            }

            if (CheckBox_Bulgur.Checked)
            {
                AddIngredient("Bulgur");
            }
            else
            {
                RemoveIngredient("Bulgur");
            }

            if (CHeckBox_Leinsamen.Checked)
            {
                AddIngredient("Leinsamen");
            }
            else
            {
                RemoveIngredient("Leinsamen");
            }

            if (CheckBox_Chiasamen.Checked)
            {
                AddIngredient("Chiasamen");
            }
            else
            {
                RemoveIngredient("Chiasamen");
            }

            if (CheckBox_Bulgur.Checked)
            {
                AddIngredient("Bulgur");
            }
            else
            {
                RemoveIngredient("Bulgur");
            }

            if (CheckBox_SalzundPfeffer.Checked)
            {
                AddIngredient("Salz");
                AddIngredient("Pfeffer");
            }
            else
            {
                RemoveIngredient("Salz");
                RemoveIngredient("Pfeffer");
            }

            if (CheckBox_Exo_Gew.Checked)
            {
                AddIngredient("Berbere");
            }
            else
            {
                RemoveIngredient("Berbere");
            }

            if (CHeckBox_Konv_Gew.Checked)
            {
                AddIngredient("Koriander");
                AddIngredient("Curry");
                AddIngredient("Currypulver");
                AddIngredient("Kreuzkümmel");
                AddIngredient("Basilikum");
                AddIngredient("Paprikapulver");
                AddIngredient("Majoran");
                AddIngredient("Muskat");
                AddIngredient("Dill");
                AddIngredient("Kurkuma");
                AddIngredient("Knoblauchpulver");
                AddIngredient("Gemüsebrühe");
                AddIngredient("Oregano");
            }
            else
            {
                RemoveIngredient("Koriander");
                RemoveIngredient("Curry");
                RemoveIngredient("Basilikum");
                RemoveIngredient("Paprikapulver");
                RemoveIngredient("Majoran");
                RemoveIngredient("Muskat");
                RemoveIngredient("Dill");
                RemoveIngredient("Kurkuma");
                RemoveIngredient("Knoblauchpulver");
                RemoveIngredient("Gemüsebrühe");
                RemoveIngredient("Currypulver");
                RemoveIngredient("Kreuzkümmel");
                RemoveIngredient("Oregano");
            }

            if (CheckBox_Fleischersatz.Checked)
            {
                AddIngredient("Seitan");
            }
            else
            {
                RemoveIngredient("Seitan");
            }

            if (CHeckBox_Tofu.Checked)
            {
                AddIngredient("Tofu");
            }
            else
            {
                RemoveIngredient("Tofu");
            }

            if (CheckBox_Ersatzjoghurt.Checked)
            {
                AddIngredient("Mandeljoghurt");
                AddIngredient("Cashewjoghurt");
                AddIngredient("Sojajoghurt");
                AddIngredient("Haferjoghurt");
                AddIngredient("Kokosjoghurt");
            }
            else
            {
                RemoveIngredient("Mandeljoghurt");
                RemoveIngredient("Cashewjoghurt");
                RemoveIngredient("Sojajoghurt");
                RemoveIngredient("Haferjoghurt");
                RemoveIngredient("Kokosjoghurt");
            }

            if (CheckBox_Ersatzmilch.Checked)
            {
                AddIngredient("pflanzliche Milch");
                AddIngredient("Pflanzenmilch");
                AddIngredient("Sojamilch");
                AddIngredient("Mandelmilch");
                AddIngredient("Kokosmilch");
                AddIngredient("Hafermilch");
            }
            else
            {
                RemoveIngredient("pflanzliche Milch");
                RemoveIngredient("Pflanzenmilch");
                RemoveIngredient("Sojamilch");
                RemoveIngredient("Mandelmilch");
                RemoveIngredient("Kokosmilch");
                RemoveIngredient("Hafermilch");
            }

            if (CHeckBox_Tief_Spinat.Checked)
            {
                AddIngredient("Spinat");
                AddIngredient("Tiefkühlspinat");
            }
            else
            {
                RemoveIngredient("Spinat");
                RemoveIngredient("Tiefkühlspinat");
            }

            if (CheckBox_Tief_Gemüse.Checked)
            {
                AddIngredient("Buttergemüse");
                AddIngredient("Tiefkühlgemüse");
            }
            else
            {
                RemoveIngredient("Buttergemüse");
                RemoveIngredient("Tiefkühlgemüse");
            }

            if (CheckBox_Tief_Obst.Checked)
            {
                AddIngredient("gefrierte Blaubeeren");
                AddIngredient("gefriertes Obst");
            }
            else
            {
                RemoveIngredient("gefrierte Blaubeeren");
                RemoveIngredient("gefriertes Obst");
            }

            if (CHeckBox_Öle.Checked)
            {
                AddIngredient("Öl");
                AddIngredient("Rapsöl");
                AddIngredient("Sonnenblumenöl");
                AddIngredient("Olivenöl");
                AddIngredient("Bratöl");
            }
            else
            {
                RemoveIngredient("Öl");
                RemoveIngredient("Rapsöl");
                RemoveIngredient("Sonnenblumenöl");
                RemoveIngredient("Olivenöl");
                RemoveIngredient("Bratöl");
            }

            if (checkBox_Essig.Checked)
            {
                AddIngredient("Apfelessig");
                AddIngredient("Essig");
            }
            else
            {
                RemoveIngredient("Apfelessig");
                RemoveIngredient("Essig");
            }

            if (CHeckBox_ExoÖle.Checked)
            {
                AddIngredient("Erdnussöl");
                AddIngredient("Sesamöl");
                AddIngredient("Kokosöl");
            }
            else
            {
                RemoveIngredient("Erdnussöl");
                RemoveIngredient("Sesamöl");
                RemoveIngredient("Kokosöl");
            }

            if (CHeckBox_Butter.Checked)
            {
                AddIngredient("Butter");
                AddIngredient("Fett");
            }
            else
            {
                RemoveIngredient("Butter");
                RemoveIngredient("Fett");
            }

            if (CheckBox_Margarine.Checked)
            {
                AddIngredient("Margarine");
                AddIngredient("Pflanzenfett");
                AddIngredient("Pflanzenbutter");
            }
            else
            {
                RemoveIngredient("Margarine");
                RemoveIngredient("Pflanzenfett");
                RemoveIngredient("Pflanzenbutter");
            }

            if (CheckBox_Hackfleisch.Checked)
            {
                AddIngredient("Hackfleisch");
            }
            else
            {
                RemoveIngredient("Hackfleisch");
            }

            if (CheckBox_Fleisch.Checked)
            {
                AddIngredient("Rindfleisch");
                AddIngredient("Rind");
                AddIngredient("Schwein");
                AddIngredient("Schweinefleisch");
                AddIngredient("Lamm");
                AddIngredient("Ente");
                AddIngredient("Kalbflesich");
            }
            else
            {
                RemoveIngredient("Rindfleisch");
                RemoveIngredient("Rind");
                RemoveIngredient("Schwein");
                RemoveIngredient("Schweinefleisch");
                RemoveIngredient("Lamm");
                RemoveIngredient("Ente");
                RemoveIngredient("Kalbflesich");
            }

            if (CheckBox_Würstchen.Checked)
            {
                AddIngredient("Würstchen");
                AddIngredient("Bratwurst");
            }
            else
            {
                RemoveIngredient("Würstchen");
                RemoveIngredient("Bratwurst");
            }

            if (checkBox_Schnitzel.Checked)
            {
                AddIngredient("Schnitzel");
                AddIngredient("Steak");
            }
            else
            {
                RemoveIngredient("Schnitzel");
                RemoveIngredient("Steak");
            }

            if (CheckBox_Hühnchen.Checked)
            {
                AddIngredient("Hühnchen");
                AddIngredient("Hähnchen");
                AddIngredient("Huhn");
                AddIngredient("Hahn");
            }
            else
            {
                RemoveIngredient("Hühnchen");
                RemoveIngredient("Hähnchen");
                RemoveIngredient("Huhn");
                RemoveIngredient("Hahn");
            }

            if (CHeckBox_Eier.Checked)
            {
                AddIngredient("Ei(er)");
            }
            else
            {
                RemoveIngredient("Ei(er)");
            }

            if (CheckBox_Nüsse.Checked)
            {
                AddIngredient("Nüsse");
                AddIngredient("Erdnüsse");
                AddIngredient("Walnüsse");
            }
            else
            {
                RemoveIngredient("Nüsse");
                RemoveIngredient("Erdnüsse");
                RemoveIngredient("Walnüsse");
            }

            if (CHeckBox_Mandeln.Checked)
            {
                AddIngredient("Mandeln");
            }
            else
            {
                RemoveIngredient("Mandeln");
            }

            if (CHeckBox_Cashew.Checked)
            {
                AddIngredient("Cashew");
                AddIngredient("Cashewkerne");
            }
            else
            {
                RemoveIngredient("Cashew");
                RemoveIngredient("Cashewkerne");
            }

            if (CheckBox_Linsen.Checked)
            {
                AddIngredient("Linsen");
                AddIngredient("rote Linsen");
                AddIngredient("Belugalinsen");
                AddIngredient("Berglinsen");
                AddIngredient("Tellerlinsen");
                AddIngredient("Pardinallinsen");
                AddIngredient("gelbe Linsen");
            }
            else
            {
                RemoveIngredient("Linsen");
                RemoveIngredient("rote Linsen");
                RemoveIngredient("Belugalinsen");
                RemoveIngredient("Berglinsen");
                RemoveIngredient("Tellerlinsen");
                RemoveIngredient("Pardinallinsen");
                RemoveIngredient("gelbe Linsen");
            }

            if (CHeckBox_Bohnen.Checked)
            {
                AddIngredient("grüne Bohnen");
                AddIngredient("Kidneybohnen");
                AddIngredient("Feuerbohnen");
                AddIngredient("Sojabohnen");
                AddIngredient("Ackerbohnen");
                AddIngredient("schwarze Bohnen");
            }
            else
            {
                RemoveIngredient("grüne Bohnen");
                RemoveIngredient("Kidneybohnen");
                RemoveIngredient("Feuerbohnen");
                RemoveIngredient("Sojabohnen");
                RemoveIngredient("Ackerbohnen");
                RemoveIngredient("schwarze Bohnen");
            }

            if (CHeckBox_Milch.Checked)
            {
                AddIngredient("Vollmilch");
                AddIngredient("laktosefreie Milch");
                AddIngredient("Milch");
            }
            else
            {
                RemoveIngredient("Vollmilch");
                RemoveIngredient("laktosefreie Milch");
                RemoveIngredient("Milch");
            }

            if (CHeckBox_Käse.Checked)
            {
                AddIngredient("Gouda");
                AddIngredient("Käse");
                AddIngredient("Emmentaler");
                AddIngredient("Schmelzkäse");
                AddIngredient("Käsestücke");
            }
            else
            {
                RemoveIngredient("Gouda");
                RemoveIngredient("Käse");
                RemoveIngredient("Emmentaler");
                RemoveIngredient("Schmelzkäse");
                RemoveIngredient("Käsestücke");
            }

            if (CheckBox_Magerquark.Checked)
            {
                AddIngredient("Magerquark");
            }
            else
            {
                RemoveIngredient("Magerquark");
            }

            if (CheckBox_Sahne.Checked)
            {
                AddIngredient("Sahne");
                AddIngredient("Schlagsahne");
            }
            else
            {
                RemoveIngredient("Sahne");
                RemoveIngredient("Schlagsahne");
            }

            if (CheckBox_Aufstriche.Checked)
            {
                AddIngredient("Frischkäse");
                AddIngredient("Käsescheiben");
                AddIngredient("Salami");
            }
            else
            {
                RemoveIngredient("Frischkäse");
                RemoveIngredient("Käsescheiben");
                RemoveIngredient("Salami");
            }

            if (CheckBox_Joghurt.Checked)
            {
                AddIngredient("Joghurt");
                AddIngredient("Buttermilch");
            }
            else
            {
                RemoveIngredient("Joghurt");
                RemoveIngredient("Buttermilch");
            }

            if (CheckBox_Fisch.Checked)
            {
                AddIngredient("Fisch");
            }
            else
            {
                RemoveIngredient("Fisch");
            }

            if (CheckBox_Fischstäbchen.Checked)
            {
                AddIngredient("Fischstäbchen");
            }
            else
            {
                RemoveIngredient("Fischstäbchen");
            }

            if (CHeckBox_Äpfel.Checked)
            {
                AddIngredient("Apfel");
                AddIngredient("Äpfel");
            }
            else
            {
                RemoveIngredient("Apfel");
                RemoveIngredient("Äpfel");
            }

            if (CheckBox_Bananen.Checked)
            {
                AddIngredient("Banane(n)");
            }
            else
            {
                RemoveIngredient("Banane(n)");
            }

            if (CheckBox_Kiwi.Checked)
            {
                AddIngredient("Kiwi");
            }
            else
            {
                RemoveIngredient("Kiwi");
            }

            if (CHeckBox_Blaubeeren.Checked)
            {
                AddIngredient("Blaubeeren");
            }
            else
            {
                RemoveIngredient("Blaubeeren");
            }

            if (CHeckBox_Birne.Checked)
            {
                AddIngredient("Birne(n)");
            }
            else
            {
                RemoveIngredient("Birne(n)");
            }

            if (CheckBox_Mehl.Checked)
            {
                AddIngredient("Mehl");
                AddIngredient("Dinkelmehl");
                AddIngredient("Weizenmehl");
                AddIngredient("Sojamehl");
            }
            else
            {
                RemoveIngredient("Mehl");
                RemoveIngredient("Dinkelmehl");
                RemoveIngredient("Weizenmehl");
                RemoveIngredient("Sojamehl");
            }

            if (CheckBox_Zucker.Checked)
            {
                AddIngredient("Zucker");
            }
            else
            {
                RemoveIngredient("Zucker");
            }

            if (CheckBox_Backpulver.Checked)
            {
                AddIngredient("Backpulver");
            }
            else
            {
                RemoveIngredient("Backpulver");
            }

            if (CheckBox_Hefe.Checked)
            {
                AddIngredient("Héfe");
                AddIngredient("Frischhefe");
                AddIngredient("Speisestärke");
                AddIngredient("Natron");
            }
            else
            {
                RemoveIngredient("Héfe");
                RemoveIngredient("Frischhefe");
                RemoveIngredient("Speisestärke");
                RemoveIngredient("Natron");
            }

            if (checkBox_Kakao.Checked)
            {
                AddIngredient("Kakao");
                AddIngredient("Schokolade");
                AddIngredient("Kakaopulver");
                AddIngredient("dunkle Schokolade");
            }
            else
            {
                RemoveIngredient("Kakao");
                RemoveIngredient("Schokolade");
                RemoveIngredient("Kakaopulver");
                RemoveIngredient("dunkle Schokolade");
            }

            if (checkBox_Wasser.Checked)
            {
                AddIngredient("Wasser");
                AddIngredient("Mineralwasser");
                AddIngredient("Sprudelwasser");
            }
            else
            {
                RemoveIngredient("Wasser");
                RemoveIngredient("Mineralwasser");
                RemoveIngredient("Sprudelwasser");
            }

            if (checkBox_Orangensaft.Checked)
            {
                AddIngredient("Osaft");
                AddIngredient("Orangensaft");
            }
            else
            {
                RemoveIngredient("Osaft");
                RemoveIngredient("Orangensaft");
            }

            if (checkBox_ZitronenLimonade.Checked)
            {
                AddIngredient("Zitronen-Limonade");
                AddIngredient("Zitronenlimonade");
                AddIngredient("Zitronenlimo");
            }
            else
            {
                RemoveIngredient("Zitronen-Limonade");
                RemoveIngredient("Zitronenlimonade");
                RemoveIngredient("Zitronenlimo");
            }

            if (checkBox_Tomatensauce.Checked)
            {
                AddIngredient("Tomatensauce");
                AddIngredient("Tomatenpassata");
            }
            else
            {
                RemoveIngredient("Tomatensauce");
                RemoveIngredient("Tomatenpassata");
            }

            if (checkBox_Rahmsauce.Checked)
            {
                AddIngredient("Rahmsauce");
            }
            else
            {
                RemoveIngredient("Rahmsauce");
            }

            if (checkBox_Buttersauce.Checked)
            {
                AddIngredient("Buttersauce");
            }
            else
            {
                RemoveIngredient("Buttersauce");
            }

            if (checkBox_Hollandaise.Checked)
            {
                AddIngredient("Hollandaise");
            }
            else
            {
                RemoveIngredient("Hollandaise");
            }
        }

        /// <summary>
        /// ChckBoxen zum Checken ganzer Bereiche wie z.b. Gemüse
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        #region Checkbox um alle Checkboxen zu aktivieren als auch zu deaktivieren 
        private void CheckBox_AlleBackwaren_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBox_AlleBackwaren.Checked)
            {
                CheckBox_Mehl.Checked = true;
                checkBox_Kakao.Checked = true;
                CheckBox_Zucker.Checked = true;
                CheckBox_Hefe.Checked = true;
                CheckBox_Backpulver.Checked = true;
            }
            else
            {
                CheckBox_Mehl.Checked = false;
                checkBox_Kakao.Checked = false;
                CheckBox_Zucker.Checked = false;
                CheckBox_Hefe.Checked = false;
                CheckBox_Backpulver.Checked = false;
            }
        }

        private void CheckBox_AlleObst_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBox_AlleObst.Checked)
            {
                CHeckBox_Birne.Checked = true;
                CHeckBox_Äpfel.Checked = true;
                CheckBox_Bananen.Checked = true;
                CHeckBox_Blaubeeren.Checked = true;
                CheckBox_Kiwi.Checked = true;
            }
            else
            {
                CHeckBox_Birne.Checked = false;
                CHeckBox_Äpfel.Checked = false;
                CheckBox_Bananen.Checked = false;
                CHeckBox_Blaubeeren.Checked = false;
                CheckBox_Kiwi.Checked = false;
            }
        }

        private void CheckBox_AlleFisch_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_AlleFisch.Checked)
            {
                CheckBox_Fisch.Checked = true;
                CheckBox_Fischstäbchen.Checked = true;
            }
            else
            {
                CheckBox_Fisch.Checked = false;
                CheckBox_Fischstäbchen.Checked = false;
            }
        }

        private void CheckBox_AlleMilchprodukte_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_AlleMilchprodukte.Checked)
            {
                CHeckBox_Milch.Checked = true;
                CHeckBox_Käse.Checked = true;
                CheckBox_Joghurt.Checked = true;
                CheckBox_Aufstriche.Checked = true;
                CheckBox_Magerquark.Checked = true;
                CheckBox_Sahne.Checked = true;
            }
            else
            {
                CHeckBox_Milch.Checked = false;
                CHeckBox_Käse.Checked = false;
                CheckBox_Joghurt.Checked = false;
                CheckBox_Aufstriche.Checked = false;
                CheckBox_Magerquark.Checked = false;
                CheckBox_Sahne.Checked = false;
            }
        }

        private void CheckBox_Tiefgekühlt_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_Tiefgekühlt.Checked)
            {
                CHeckBox_Tief_Spinat.Checked = true;
                CheckBox_Tief_Gemüse.Checked = true;
                CheckBox_Tief_Obst.Checked = true;
            }
            else
            {
                CHeckBox_Tief_Spinat.Checked = false;
                CheckBox_Tief_Gemüse.Checked = false;
                CheckBox_Tief_Obst.Checked = false;
            }
        }

        private void CheckBox_AlleProteine_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_AlleProteine.Checked)
            {
                CheckBox_Nüsse.Checked = true;
                CHeckBox_Eier.Checked = true;
                CHeckBox_Mandeln.Checked = true;
                CHeckBox_Cashew.Checked = true;
                CheckBox_Linsen.Checked = true;
                CHeckBox_Bohnen.Checked = true;
            }
            else
            {
                CheckBox_Nüsse.Checked = false;
                CHeckBox_Eier.Checked = false;
                CHeckBox_Mandeln.Checked = false;
                CHeckBox_Cashew.Checked = false;
                CheckBox_Linsen.Checked = false;
                CHeckBox_Bohnen.Checked = false;
            }
        }

        private void CheckBox_AlleFleisch_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_AlleFleisch.Checked)
            {
                CheckBox_Hühnchen.Checked = true;
                CheckBox_Fleisch.Checked = true;
                CheckBox_Würstchen.Checked = true;
                checkBox_Schnitzel.Checked = true;
                CheckBox_Hackfleisch.Checked = true;
            }
            else
            {
                CheckBox_Hühnchen.Checked = false;
                CheckBox_Fleisch.Checked = false;
                CheckBox_Würstchen.Checked = false;
                checkBox_Schnitzel.Checked = false;
                CheckBox_Hackfleisch.Checked = false;
            }
        }

        private void CheckBox_AlleVeggie_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_AlleVeggie.Checked)
            {
                CheckBox_Ersatzjoghurt.Checked = true;
                CheckBox_Ersatzmilch.Checked = true;
                CHeckBox_Tofu.Checked = true;
                CheckBox_Fleischersatz.Checked = true;
            }
            else
            {
                CheckBox_Ersatzjoghurt.Checked = false;
                CheckBox_Ersatzmilch.Checked = false;
                CHeckBox_Tofu.Checked = false;
                CheckBox_Fleischersatz.Checked = false;
            }
        }

        private void CheckBox_Alle_Fette_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_Alle_Fette.Checked)
            {
                CHeckBox_Öle.Checked = true;
                CHeckBox_Butter.Checked = true;
                CheckBox_Margarine.Checked = true;
                CHeckBox_ExoÖle.Checked = true;
                checkBox_Essig.Checked = true;
            }
            else
            {
                CHeckBox_Öle.Checked = false;
                CHeckBox_Butter.Checked = false;
                CheckBox_Margarine.Checked = false;
                CHeckBox_ExoÖle.Checked = false;
                checkBox_Essig.Checked = false;
            }
        }

        private void CheckBox_AlleGewürze_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBox_AlleGewürze.Checked)
            {
                CheckBox_SalzundPfeffer.Checked = true;
                CHeckBox_Konv_Gew.Checked = true;
                CheckBox_Exo_Gew.Checked = true;
            }
            else
            {
                CheckBox_SalzundPfeffer.Checked = false;
                CHeckBox_Konv_Gew.Checked = false;
                CheckBox_Exo_Gew.Checked = false;
            }
        }

        private void CheckBox_AlleKohlenhydrate_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_AlleKohlenhydrate.Checked)
            {
                CHeckBox_Nudeln.Checked = true;
                CheckBox_Reis.Checked = true;
                CheckBox_Quinoa.Checked = true;
                CheckBox_Bulgur.Checked = true;
                CheckBox_Haferflocken.Checked = true;
                CHeckBox_Leinsamen.Checked = true;
                CheckBox_Chiasamen.Checked = true;
            }
            else
            {
                CHeckBox_Nudeln.Checked = false;
                CheckBox_Reis.Checked = false;
                CheckBox_Quinoa.Checked = false;
                CheckBox_Bulgur.Checked = false;
                CheckBox_Haferflocken.Checked = false;
                CHeckBox_Leinsamen.Checked = false;
                CheckBox_Chiasamen.Checked = false;
            }
        }

        private void Alle_Gemüse_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBox_Alle_Gemüse.Checked)
            {
                CheckBox_Zwiebeln.Checked = true;
                CheckBox_Knoblauch.Checked = true;
                CheckBox_Tomaten.Checked = true;
                CheckBox_Kartoffeln.Checked = true;
                CheckBox_Zuccini.Checked = true;
                CheckBox_Karotten.Checked = true;
                CheckBox_Paprika.Checked = true;
                CheckBox_Aubergine.Checked = true;
                checkBox_ingwer.Checked = true;
            }
            else
            {
                CheckBox_Zwiebeln.Checked = false;
                CheckBox_Knoblauch.Checked = false;
                CheckBox_Tomaten.Checked = false;
                CheckBox_Kartoffeln.Checked = false;
                CheckBox_Zuccini.Checked = false;
                CheckBox_Karotten.Checked = false;
                CheckBox_Paprika.Checked = false;
                CheckBox_Aubergine.Checked = false;
                checkBox_ingwer.Checked = false;
            }
        }
        private void CheckBox_GEtränke_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_GEtränke.Checked)
            {
                checkBox_Wasser.Checked = true;
                checkBox_Orangensaft.Checked = true;
                checkBox_ZitronenLimonade.Checked = true;
            }
            else
            {
                checkBox_Wasser.Checked = false;
                checkBox_Orangensaft.Checked = false;
                checkBox_ZitronenLimonade.Checked = false;
            }
        }
        private void CheckBox_Saucen_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_Saucen.Checked)
            {
                checkBox_Hollandaise.Checked = true;
                checkBox_Tomatensauce.Checked = true;
                checkBox_Rahmsauce.Checked = true;
                checkBox_Buttersauce.Checked = true;
            }
            else
            {
                checkBox_Hollandaise.Checked = false;
                checkBox_Tomatensauce.Checked = false;
                checkBox_Rahmsauce.Checked = false;
                checkBox_Buttersauce.Checked = false;
            }
        }
        #endregion


        public void AddIngredient(string addingredient)
        {
            if(!RecipeFilterForm.recipeFilterForm.CheckWhetherIngredientIsInsideIngredientList(new Ingredient(addingredient),RecipeFilter.recipeFilter.IngredientAvaliable))
            {
                RecipeFilter.recipeFilter.IngredientAvaliable.Add(new Ingredient(addingredient));
            }
        }

        public void RemoveIngredient(string removeingredient)
        {
            for (int i = 0; i < RecipeFilter.recipeFilter.IngredientAvaliable.Count; i++)
            {
                if (RecipeFilter.recipeFilter.IngredientAvaliable[i].Name == removeingredient)
                {
                    RecipeFilter.recipeFilter.IngredientAvaliable.RemoveAt(i);
                }
            }
        }

        /// <summary>
        /// Knopf zum Hinzufügen eiger Zutaten für die dauerhaft vorhandenen Zutaten
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Selbsteingabe_Click(object sender, EventArgs e)
        {
            SelfInputForm.selfInputForm.ShowDialog();
        }

        /// <summary>
        /// Löschen aller selbsteingegebenen Zutaten
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_SelfInput_Delete_Click(object sender, EventArgs e)
        {
            List<string> CheckForDoubles = new List<string>();
            for (int i = 0; i < SelfInputForm.selfInputForm.listBox1.Items.Count; i++)
            {
                foreach (Ingredient ingredient in RecipeFilter.recipeFilter.IngredientAvaliable.ToList())
                {
                    if (ingredient.Name.ToLower() == Convert.ToString(SelfInputForm.selfInputForm.listBox1.Items[i])?.ToLower() && !CheckForDoubles.Contains(ingredient.Name))
                    {
                        RecipeFilter.recipeFilter.IngredientAvaliable.Remove(ingredient);
                        CheckForDoubles.Add(ingredient.Name);
                        if (i > 0)
                        {
                            i--;
                        }
                    }
                }
            }
            CheckForDoubles.Clear();
            SelfInputForm.selfInputForm.listBox1.Items.Clear();
        }

        /// <summary>
        /// Tooltip zum Anzeigen welche Zutaten in einer unklaren Checkbox enthalten sind
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        #region ToolTip Info für alle unklaren oder zu generalisierte Checkboxen
        // Nudeln Info
        private void ovalPictureBox1_MouseHover(object sender, EventArgs e)
        {
            GiveValueToInfo("Nudeln, Vollkorn Nudeln, Penne, Spaghetti, Fusili Nudeln", ovalPictureBox1);
        }
        // Reis Info
        private void ovalPictureBox2_MouseHover(object sender, EventArgs e)
        {
            GiveValueToInfo("Reis, Basmatireis", ovalPictureBox2);
        }
        //konv Gewürze Info
        private void ovalPictureBox3_Click(object sender, EventArgs e)
        {
            GiveValueToInfo("Koriander, Curry, Currypulver, Kreuzkümmel, Basilikum, Paprikapulver,\nMajoran, Muskat, Dill, Kurkuma, Oregano, Knoblauchpulver, Gemüsebrühe", ovalPictureBox3);
        }
        // ExoGewürze
        private void ovalPictureBox4_Click(object sender, EventArgs e)
        {
            GiveValueToInfo("Berbere", ovalPictureBox4);
        }
        // Fleisch
        private void ovalPictureBox5_Click(object sender, EventArgs e)
        {
            GiveValueToInfo("Rindfleisch, Rind, Schwein, Schweinefleisch, Lamm, Ente, Kalbflesich", ovalPictureBox5);
        }
        // konv Öle
        private void ovalPictureBox7_Click(object sender, EventArgs e)
        {
            GiveValueToInfo("Öl, Rapsöl, Sonnenblumenöl, Olivenöl, Bratöl", ovalPictureBox7);
        }

        // Exo Öle
        private void ovalPictureBox8_Click(object sender, EventArgs e)
        {
            GiveValueToInfo("Erdnussöl, Sesamöl, Kokosöl", ovalPictureBox8);
        }
        // Fleischersatz
        private void ovalPictureBox10_Click(object sender, EventArgs e)
        {
            GiveValueToInfo("Seitan",ovalPictureBox10);
        }
        //Pflanzenmilch
        private void ovalPictureBox11_Click(object sender, EventArgs e)
        {
            GiveValueToInfo("pflanzliche Milch, Pflanzenmilch, Sojamilch, Mandelmilch, Kokosmilch, Hafermilch", ovalPictureBox11);
        }
        //Ersatzjoghurt
        private void ovalPictureBox12_Click(object sender, EventArgs e)
        {
            GiveValueToInfo("Mandeljoghurt, Cashewjoghurt, Sojajoghurt, Haferjoghurt, Kokosjoghurt", ovalPictureBox12);
        }
        //Fisch
        private void ovalPictureBox6_Click(object sender, EventArgs e)
        {
            GiveValueToInfo("Fisch", ovalPictureBox6);
        }
        // Nüsse
        private void ovalPictureBox9_Click(object sender, EventArgs e)
        {
            GiveValueToInfo("Nüsse, Erdnüsse, Walnüsse", ovalPictureBox9);
        }
        //Linsen
        private void ovalPictureBox16_Click(object sender, EventArgs e)
        {
            GiveValueToInfo("Linsen, rote Linsen, Belugalinsen, Berglinsen, Tellerlinsen, Pardinallinsen, gelbe Linsen", ovalPictureBox16);
        }
        //Bohnen
        private void ovalPictureBox15_Click(object sender, EventArgs e)
        {
            GiveValueToInfo("grüne Bohnen, Kidneybohnen, Feuerbohnen, Sojabohnen, Ackerbohnen, schwarze Bohnen", ovalPictureBox15);
        }
        //Milch
        private void ovalPictureBox13_Click(object sender, EventArgs e)
        {
            GiveValueToInfo("Vollmilch, laktosefreie Milch, Milch", ovalPictureBox13);
        }
        //Käse
        private void ovalPictureBox14_Click(object sender, EventArgs e)
        {
            GiveValueToInfo("Gouda, Käse, Emmentaler, Schmelzkäse, Käsestücke", ovalPictureBox14);
        }

        private void toolTip1_Draw_1(object sender, DrawToolTipEventArgs e)
        {
            e.DrawBackground();
            e.DrawBorder();
            e.DrawText();
        }
        #endregion

        
        // Genutzte Methoden zum Verhindern von Copy Paste
        private void GiveValueToInfo(string value, OvalPictureBox ovalPictureBox)
        {
            ovalPictureBox.BringToFront();
            toolTip1.Show(value, ovalPictureBox);
        }

        /// <summary>
        /// Checkt die Checkboxen, bei denen eine bestimmte Zutat vorhanden ist. Verwendet für das Laden der vorrätigen Zutaten für ein Profil
        /// </summary>
        /// <param name="stringList"></param>
        public void CheckAllCheckBoxes(List<string> stringList)
        {
            foreach (string ingredientname in stringList)
            {
                if (ingredientname == "Zwiebel(n)")
                {
                    CheckBox_Zwiebeln.Checked = true;
                }
                if (ingredientname == "Mehl")
                {
                    CheckBox_Mehl.Checked = true;
                }
                if (ingredientname == "Zucker")
                {
                    CheckBox_Zucker.Checked = true;
                }
                if (ingredientname == "Backpulver")
                {
                    CheckBox_Backpulver.Checked = true;
                }
                if (ingredientname == "Kakaopulver")
                {
                    checkBox_Kakao.Checked = true;
                }
                if (ingredientname == "Natron")
                {
                    CheckBox_Hefe.Checked = true;
                }
                if (ingredientname == "Äpfel")
                {
                    CHeckBox_Äpfel.Checked = true;
                }
                if (ingredientname == "Banane(n)")
                {
                    CheckBox_Bananen.Checked = true;
                }
                if (ingredientname == "Kiwi")
                {
                    CheckBox_Kiwi.Checked = true;
                }
                if (ingredientname == "Blaubeeren")
                {
                    CHeckBox_Blaubeeren.Checked = true;
                }
                if (ingredientname == "Birne(n)")
                {
                    CHeckBox_Birne.Checked = true;
                }
                if (ingredientname == "Tomatensauce")
                {
                    checkBox_Tomatensauce.Checked = true;
                }
                if (ingredientname == "Rahmsauce")
                {
                    checkBox_Rahmsauce.Checked = true;
                }
                if (ingredientname == "Buttersauce")
                {
                    checkBox_Buttersauce.Checked = true;
                }
                if (ingredientname == "Hollandaise")
                {
                    checkBox_Hollandaise.Checked = true;
                }
                if (ingredientname == "Ei(er)")
                {
                    CHeckBox_Eier.Checked = true;
                }
                if (ingredientname == "Nüsse")
                {
                    CheckBox_Nüsse.Checked = true;
                }
                if (ingredientname == "Mandeln")
                {
                    CHeckBox_Mandeln.Checked = true;
                }
                if (ingredientname == "Cashew")
                {
                    CHeckBox_Cashew.Checked = true;
                }
                if (ingredientname == "Linsen")
                {
                    CheckBox_Linsen.Checked = true;
                }
                if (ingredientname == "Kidneybohnen")
                {
                    CHeckBox_Bohnen.Checked = true;
                }

                if (ingredientname == "Knoblauch")
                {
                    CheckBox_Knoblauch.Checked = true;
                }
                if (ingredientname == "Tomate(n)")
                {
                    CheckBox_Tomaten.Checked = true;
                }
                if (ingredientname == "Zucchini")
                {
                    CheckBox_Zuccini.Checked = true;
                }
                if (ingredientname == "Paprika")
                {
                    CheckBox_Paprika.Checked = true;
                }
                if (ingredientname == "Möhre(n)")
                {
                    CheckBox_Karotten.Checked = true;
                }
                if (ingredientname == "Ingwer")
                {
                    checkBox_ingwer.Checked = true;
                }
                if (ingredientname == "Nudeln")
                {
                    CHeckBox_Nudeln.Checked = true;
                }
                if (ingredientname == "Reis")
                {
                    CheckBox_Reis.Checked = true;
                }
                if (ingredientname == "Quiona")
                {
                    CheckBox_Quinoa.Checked = true;
                }
                if (ingredientname == "Bulgur")
                {
                    CheckBox_Bulgur.Checked = true;
                }
                if (ingredientname == "Haferflocken")
                {
                    CheckBox_Haferflocken.Checked = true;
                }
                if (ingredientname == "Leinsamen")
                {
                    CHeckBox_Leinsamen.Checked = true;
                }
                if (ingredientname == "Chiasamen")
                {
                    CheckBox_Chiasamen.Checked = true;
                }
                if (ingredientname == "Salz")
                {
                    CheckBox_SalzundPfeffer.Checked = true;
                }
                if (ingredientname == "Koriander")
                {
                    CHeckBox_Konv_Gew.Checked = true;
                }
                if (ingredientname == "Berbere")
                {
                    CheckBox_Exo_Gew.Checked = true;
                }
                if (ingredientname == "Hühnchen")
                {
                    CheckBox_Hühnchen.Checked = true;
                }
                if (ingredientname == "Schweinefleisch")
                {
                    CheckBox_Fleisch.Checked = true;
                }
                if (ingredientname == "Schnitzel")
                {
                    checkBox_Schnitzel.Checked = true;
                }
                if (ingredientname == "Hackfleisch")
                {
                    CheckBox_Hackfleisch.Checked = true;
                }
                if (ingredientname == "Würstchen")
                {
                    CheckBox_Würstchen.Checked = true;
                }
                if (ingredientname == "Öl")
                {
                    CHeckBox_Öle.Checked = true;
                }
                if (ingredientname == "Sesamöl")
                {
                    CHeckBox_ExoÖle.Checked = true;
                }
                if (ingredientname == "Aubergine(n)")
                {
                    CheckBox_Aubergine.Checked = true;
                }
                if (ingredientname == "Süßkartoffel(n)")
                {
                    CheckBox_Kartoffeln.Checked = true;
                }
                if (ingredientname == "Butter")
                {
                    CHeckBox_Butter.Checked = true;
                }
                if (ingredientname == "Margarine")
                {
                    CheckBox_Margarine.Checked = true;
                }
                if (ingredientname == "Essig")
                {
                    checkBox_Essig.Checked = true;
                }
                if (ingredientname == "Spinat")
                {
                    CHeckBox_Tief_Spinat.Checked = true;
                }
                if (ingredientname == "Tiefkühlgemüse")
                {
                    CheckBox_Tief_Gemüse.Checked = true;
                }
                if (ingredientname == "gefriertes Obst")
                {
                    CheckBox_Tief_Obst.Checked = true;
                }
                if (ingredientname == "Seitan")
                {
                    CheckBox_Fleischersatz.Checked = true;
                }
                if (ingredientname == "Tofu")
                {
                    CHeckBox_Tofu.Checked = true;
                }
                if (ingredientname == "Pflanzenmilch")
                {
                    CheckBox_Ersatzmilch.Checked = true;
                }
                if (ingredientname == "Mandeljoghurt")
                {
                    CheckBox_Ersatzjoghurt.Checked = true;
                }
                if (ingredientname == "Milch")
                {
                    CHeckBox_Milch.Checked = true;
                }
                if (ingredientname == "Gouda")
                {
                    CHeckBox_Käse.Checked = true;
                }
                if (ingredientname == "Joghurt")
                {
                    CheckBox_Joghurt.Checked = true;
                }
                if (ingredientname == "Frischkäse")
                {
                    CheckBox_Aufstriche.Checked = true;
                }
                if (ingredientname == "Magerquark")
                {
                    CheckBox_Magerquark.Checked = true;
                }
                if (ingredientname == "Sahne")
                {
                    CheckBox_Sahne.Checked = true;
                }
                if (ingredientname == "Wasser")
                {
                    checkBox_Wasser.Checked = true;
                }
                if (ingredientname == "Zitronenlimonade")
                {
                    checkBox_ZitronenLimonade.Checked = true;
                }
                if (ingredientname == "Orangensaft")
                {
                    checkBox_Orangensaft.Checked = true;
                }
                if (ingredientname == "Fisch")
                {
                    CheckBox_Fisch.Checked = true;
                }
                if (ingredientname == "Fischstäbchen")
                {
                    CheckBox_Fischstäbchen.Checked = true;
                }
            }
        }

        /// <summary>
        /// Auschecken aller Checkboxen. Z.B beim Ausloggen
        /// </summary>
        /// <param name="ctrl"></param>
        public void UncheckAllCheckBoxes(Control ctrl)
        {
            CheckBox chkBox = ctrl as CheckBox;
            if (chkBox == null)
            {
                foreach (Control child in ctrl.Controls)
                {
                    UncheckAllCheckBoxes(child);
                }
            }
            else
            {
                chkBox.Checked = false;
            }
        }
    }
}
