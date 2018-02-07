using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Sis_Administracion.DAL.Servicios
{
    public static class FormularioServicios
    {
        /****************************/
        /***   VERIFICAR DATOS    ***/
        /****************************/
        public static bool EsDni(string txt)
        {
            if(txt == "") return false;

            // Entre 7 y 8 caracateres
            if (txt.Length != 8 && txt.Length != 7)
                return false;

            // Todos numeros
            return txt.All(char.IsNumber);
        }

        public static bool EsCuit(string txt)
        {
            if (txt == "") return false;

            // 11 caracteres
            if (txt.Length != 11)
                return false;

            // Todos Numeros
            return txt.All(char.IsNumber);
        }

        public static bool EsApyNom(string txt)
        {
            if (txt == "") return false;

            // Solo Letras y espacios
            return txt.All(c => char.IsSeparator(c) || char.IsLetter(c));
        }

        public static bool EsTelefono(string txt)
        {
            if (txt == "") return false;

            // entre 7 y 15 caracteres
            if (txt.Length < 7 && txt.Length > 15)
                return false;

            // Todos numeros
            return txt.All(char.IsNumber);
        }

        public static bool EsPassword(string txt)
        {
            if (txt == "") return false;

            bool may = false;
            bool min = false;
            bool num = false;

            // Minimo 8 caracteres
            if (txt.Length < 8 && txt.Length >16) return false;

            // Contener Mayusculas, Minusculas y numeros
            foreach (char c in txt)
            {
                if ( char.IsNumber(c) ) num = true;
                if ( char.IsUpper(c)  ) may = true;
                if ( char.IsLower(c)  ) min = true;
            }

            return may && min && num;
        }

        public static bool EsDireccion(string txt)
        {
            if (txt == "") return false;

            // Solo letras y numeros
            return txt.All(c => char.IsSeparator(c) 
                            || char.IsLetter(c) 
                            || char.IsNumber(c) );
        }

        public static bool EsCodigoDeBarra(string txt)
        {
            if (txt == "") return false;

            if (txt.Length == 12 || txt.Length == 13) return false;

            // Solo numeros
            return txt.All(char.IsNumber);
        }

        public static bool EsCodigoDeProducto(string txt)
        {
            if (txt == "") return false;

            if (txt.Length <= 4 || txt.Length >= 13) return false;

            // Solo letras y numeros
            return txt.All(char.IsLetterOrDigit);
        }


        /****************************/
        /***   RESALTAR ERRORES   ***/
        /****************************/
        public static void ResaltarPanelConError(Panel panel)
        {
            // Seleccion de color
            Color eErr = Color.LightSalmon;
            panel.BackColor = eErr;

            foreach (var c in panel.Controls)
            {

                // Si es Panel vuelvo a llamar a la funcion
                if (c is Panel pnl)
                    ResaltarPanelConError(pnl);

                // Asigo fondo a los controles
                if (c is TextBox txt)
                    txt.BackColor = eErr;

                if (c is NumericUpDown nud)
                    nud.BackColor = eErr;

                if (c is RichTextBox rtb)
                    rtb.BackColor = eErr;

                if (c is ComboBox cbo)
                    cbo.BackColor = eErr;

                if (c is ListBox lst)
                    lst.BackColor = eErr;
            }
        }

        public static void QuitarResaltadoError(Panel panel)
        {
            // Seleccion de color
            Color eErr = Color.White;
            panel.BackColor = eErr;

            foreach (var c in panel.Controls)
            {
                // Si es Panel vuelvo a llamar a la funcion
                if (c is Panel pnl)
                    ResaltarPanelConError(pnl);

                // Asigo fondo a los controles
                if (c is TextBox txt)
                    txt.BackColor = eErr;

                if (c is NumericUpDown nud)
                    nud.BackColor = eErr;

                if (c is RichTextBox rtb)
                    rtb.BackColor = eErr;

                if (c is ComboBox cbo)
                    cbo.BackColor = eErr;

                if (c is ListBox lst)
                    lst.BackColor = eErr;
            }
        }

    }
}
