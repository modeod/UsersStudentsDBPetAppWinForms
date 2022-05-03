using System.Text.RegularExpressions;
using static System.Windows.Forms.Control;

namespace UsersStudentsDBForm.Extensions
{
    public static class TextBoxValidators
    {
        private static ErrorProvider errorProvider = new ErrorProvider()
        {
            BlinkStyle = ErrorBlinkStyle.NeverBlink
        };

        public static void errorProviderOff(TextBox tb)
        {
            errorProvider.SetError(tb, "");

        }

        public static void errorProviderOff(List<TextBox> boxes)
        {
            foreach (TextBox tb in boxes)
            {
                errorProvider.SetError(tb, "");
            }
        }

        public static bool validateFirstName(TextBox tb)
        {
            if (tb.Text.Trim().Length < 1)
            {
                errorProvider.SetError(tb, "Введите имя");
                return false;
            }

            errorProviderOff(tb);
            return true;
        }

        public static bool validateEmail(TextBox tb)
        {
            string text = tb.Text.Trim();
            Regex reg = new Regex(@"(\w+)@(\w+)\.(\w+)");
            MatchCollection match = reg.Matches(text);

            if (match.Count < 1 && text.Length > 0)
            {
                errorProvider.SetError(tb, "Почта не введена или введена неправильно");
                return false;
            }

            errorProviderOff(tb);
            return true;
        }

        public static bool validatePhone(TextBox tb)
        {
            string text = tb.Text.Trim();
            Regex reg = new Regex(@"\+(\d{1,3})\(\d{2}\)\d{3}-\d{2}-\d{2}");
            MatchCollection match = reg.Matches(text);

            if (match.Count < 1 && text.Length > 0)
            {
                errorProvider.SetError(tb, "Пример формата: +380(98)765-43-21");
                return false;
            }

            errorProviderOff(tb);
            return true;
        }

        public static bool validateTelegram(TextBox tb)
        {
            string text = tb.Text.Trim();

            Regex reg = new Regex(@"@\S*");
            MatchCollection match = reg.Matches(text);
            
            if (match.Count < 1 && text.Length > 0)
            {
                errorProvider.SetError(tb, "Пример формата: @userName");
                return false;
            }

            errorProviderOff(tb);
            return true;
        }

        public static bool validateDOB(TextBox tb)
        {
            string text = tb.Text.Trim();
            Regex reg = new Regex(@"\d{2}\.\d{2}\.\d{4}");
            MatchCollection match = reg.Matches(text);

            if (match.Count < 1 && text.Length > 0)
            {
                errorProvider.SetError(tb, "Пример формата: 11.05.1999 (dd.mm.yyyy)");
                return false;
            }

            errorProviderOff(tb);
            return true;
        }
    }
}
