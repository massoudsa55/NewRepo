using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Cabinet_Medical.Functions
{
    static class Master
    {
        //  'db'  Object of Database
        public static DAL.Database db = new DAL.Database();

        public static byte [] GetByteFromImage(Image image)
        {
            using (MemoryStream stream = new MemoryStream())
            {
                try
                {
                    image.Save(stream, ImageFormat.Jpeg);
                    return stream.ToArray();
                }
                catch (Exception)
                {
                    return stream.ToArray();
                }
            }
        }

        public static Image GetImageFromByteArray(byte[] byteImage)
        {
            Image img;
            try
            {
                MemoryStream stream = new MemoryStream(byteImage, false);
                img = Image.FromStream(stream);
            }
            catch
            {
                img = null;
            }
            return img;
        }

        public static bool IsDateValide(DateEdit date)
        {
            if (date.DateTime.Year < 1950)
            {
                date.ErrorText = Properties.Settings.Default.ErrorText;
                return false;
            }
            return true;
        }

        public static bool IsTextValide(TextEdit txt)
        {
            if (txt.Text.Trim() == string.Empty)
            {
                txt.ErrorText = Properties.Settings.Default.ErrorText;
                return false;
            }
            return true;
        }

        public static bool IsEditValueValide(LookUpEditBase lkp)
        {
            if (lkp.Text == string.Empty || lkp.EditValue == null)
            {
                lkp.ErrorText = Properties.Settings.Default.ErrorText;
                return false;
            }
            return true;
        }

        public static bool IsEditValueValideAndNotZero(LookUpEditBase lkp)
        {
            if (lkp.Properties.NullText == string.Empty || (lkp.Text == string.Empty || lkp.EditValue == null))
            {
                lkp.ErrorText = Properties.Settings.Default.ErrorText;
                return false;
            }
            return true;
        }
        public static bool IsEditValueOfTypeInt(LookUpEditBase lkp) => (lkp.EditValue is int || lkp.EditValue is byte);

        //Method For Ptient
        public static string GetNewCode()
        {
            string maxCode;
            maxCode = Master.db.Patient.Select(a => a.Code).Max();
            return GetNextCodeIsString(maxCode);
        }
        //Method For Ptient
        public static string GetNextCodeIsString(string maxCode)
        {
            if (maxCode == string.Empty || maxCode == null)
                return "PTN001";
            string str1 = "";
            foreach (char c in maxCode)
                str1 = char.IsDigit(c) ? str1 + c.ToString() : "";
            if (str1 == string.Empty)
                return maxCode + "001";
            string str2 = str1.Insert(0, "1");
            str2 = (Convert.ToInt32(str2) + 1).ToString();
            string str3 = str2[0] == '1' ? str2.Remove(0, 1) : str2.Remove(0, 1).Insert(0, "1");
            int index = maxCode.LastIndexOf(str1);
            maxCode = maxCode.Remove(index);
            maxCode = maxCode.Insert(index, str3);
            return maxCode;
        }

        public static string GetDaira(int id)
        {
            if (id != 0)
            {
                var Daira = Master.db.Daira.First(a => a.ID_Daira == id).NameDaira;
                if (Daira != string.Empty)
                    return Daira;
            }
            return "";
        }

        public static string GetWilaya(int id)
        {
            if (id != 0)
            {
                int id_Wilaya = (int?)Master.db.Daira.First(a => a.ID_Daira == id).ID_Wilaya ?? 0;
                var Wilaya = Master.db.Wilaya.First(a => a.ID_Wilaya == id_Wilaya).NameWilaya;
                if (Wilaya != string.Empty)
                    return Wilaya;
            }
            return "";
        }

        public static string GetPays(int id)
        {
            if (id != 0)
            {
                int id_Wilaya = (int?)Master.db.Daira.First(a => a.ID_Daira == id).ID_Wilaya ?? 0;
                int id_pays = (int?)Master.db.Wilaya.First(a => a.ID_Wilaya == id_Wilaya).ID_Pays ?? 0;
                var payse = Master.db.Pays.First(a => a.ID_Pays == id_pays).NamePay;
                if (payse != string.Empty)
                    return payse;
            }
            return "";
        }

        public static string GetSexe(int id)
        {
            if (id != 0)
            {
                var sexe = Master.db.Sexe.First(a => a.ID_Sexe == id).Type;
                if (sexe != string.Empty)
                    return sexe;
            }
            return "";
        }

        public static string GetCivilite(int id)
        {
            if (id != 0)
            {
                var civilite = Master.db.Civilite.First(a => a.ID_Civilite == id).Type;
                if (civilite != string.Empty)
                    return civilite;
            }
            return "";
        }

        public static string GetGroupeSanguin(int id)
        {
            if (id != 0)
            {
                var groupeSanguin = Master.db.GroupeSanguin.First(a => a.ID_GroupeSanguin == id).Type;
                if (groupeSanguin != string.Empty)
                    return groupeSanguin;
            }
            return "";
        }

        public static string GetSituationFam(int id)
        {
            if (id != 0)
            {
                var situationFam = Master.db.SituationFam.First(a => a.ID_SF == id).Type;
                if (situationFam != string.Empty)
                    return situationFam;
            }
            return "";
        }

        public static string GetNomPatient(int id)
        {
            if (id != 0)
            {
                var nom = Master.db.Patient.First(a => a.ID_Patient == id).Nom;
                if (nom != string.Empty)
                    return nom;
            }
            return "";
        }

        public static string GetPrenomPatient(int id)
        {
            if (id != 0)
            {
                var prenom = Master.db.Patient.First(a => a.ID_Patient == id).Prenom;
                if (prenom != string.Empty)
                    return prenom;
            }
            return "";
        }

    }
}
