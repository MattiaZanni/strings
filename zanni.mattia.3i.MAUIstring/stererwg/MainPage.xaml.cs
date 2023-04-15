using System.Runtime.InteropServices;

namespace stererwg;

public partial class MainPage : ContentPage
{

    public MainPage()
    {
        InitializeComponent();
    }

    static int Long(string TextIn)
    {
        char[] caratteri = TextIn.ToCharArray();
        int Valore = 0;

        foreach (char c in caratteri)
            Valore++;

        return Valore;
    }


    int Lettere(string TextIn)
    {
        char[] txtCharArray = TextIn.ToCharArray();
        int Valore = 0;

        for (int i = 0; i < Long(TextIn); i++)
            if ((txtCharArray[i] >= 'A') && (txtCharArray[i] <= 'Z') ||
               (txtCharArray[i] >= 'a') && (txtCharArray[i] <= 'z'))
                Valore++;

        return Valore;
    }

    int Parole(string TextIn)
    {
        char[] txtCharArray = TextIn.ToCharArray();
        int Valore = 0;

        for (int i = 0; i < Long(TextIn) - 1; i++)
            if (((txtCharArray[i + 1] >= 'A') && (txtCharArray[i + 1] <= 'Z') ||
               (txtCharArray[i + 1] >= 'a') && (txtCharArray[i + 1] <= 'z')) &&
               txtCharArray[i] == ' ')

                Valore++;
        Valore++;

        return Valore;
    }

    string Sutxt(string TextIn)
    {
        char[] txtCharArray = TextIn.ToCharArray();

        for (int i = 0; i < Long(TextIn); i++)
            if ((txtCharArray[i] >= 'a') && (txtCharArray[i] <= 'z'))
            {
                int charInt = (int)txtCharArray[i] & 0x5f;
                txtCharArray[i] = (char)charInt;
            }

        return new string(txtCharArray);
    }

    string Giutxt(string TextIn)
    {
        char[] txtCharArray = TextIn.ToCharArray();

        for (int i = 0; i < Long(TextIn); i++)
            if ((txtCharArray[i] >= 'A') && (txtCharArray[i] <= 'Z'))
            {
                int x = (int)txtCharArray[i] | 0x20;
                txtCharArray[i] = (char)x;

            }

        return new string(txtCharArray);
    }

    string Contrariotxt(string TextIn)
    {
        char[] txtCharArray = TextIn.ToCharArray();
        char[] txtCharArrayReverse = new char[Long(TextIn)];


        for (int i = 0; i < Long(TextIn); i++)
        {
            txtCharArrayReverse[i] = (char)txtCharArray[Long(TextIn) - i - 1];
        }

        return new string(txtCharArrayReverse);
    }

    bool Alphabeto(string TextIn)
    {
        char[] txtCharArray = TextIn.ToCharArray();

        for (int i = 0; i < Long(TextIn); i++)
            if (!((txtCharArray[i] >= 'a') && (txtCharArray[i] <= 'z') ||
               (txtCharArray[i] >= 'A') && (txtCharArray[i] <= 'Z')))
                return false;

        return true;
    }

    bool Alphanumer(string TextIn)
    {
        char[] txtCharArray = TextIn.ToCharArray();

        for (int i = 0; i < Long(TextIn); i++)
            if (!((txtCharArray[i] >= 'a') && (txtCharArray[i] <= 'z') ||
               (txtCharArray[i] >= 'A') && (txtCharArray[i] <= 'Z') ||
               (txtCharArray[i] >= '1') && (txtCharArray[i] <= '9')))

                return false;

        return true;
    }

    bool Palin(string TextIn)
    {
        if (Giutxt(TextIn) == Giutxt(Contrariotxt(TextIn)))
            return true;

        return false;
    }

    string Cap(string TextIn)
    {

        char[] txtCharArray = TextIn.ToCharArray();

        int charInt = (int)txtCharArray[0] & 0x5f;
        txtCharArray[0] = (char)charInt;

        for (int i = 0; i < Long(TextIn) - 1; i++)
            if (((txtCharArray[i + 1] >= 'a') && (txtCharArray[i + 1] <= 'z')) && txtCharArray[i] == ' ')
            {
                charInt = (int)txtCharArray[i + 1] & 0x5f;
                txtCharArray[i + 1] = (char)charInt;
            }
        return new string(txtCharArray);
    }

    

    private void ButStr(object sender, EventArgs e) {
        StringOut.Text =
            $"Quante parole: {Parole(StringIn.Text)} \n" +
            $"Maiuscolo: {Sutxt(StringIn.Text)} \n" +
            $"Minuscolo {Giutxt(StringIn.Text)} \n" +
            $"Capitalized: {Cap(StringIn.Text)} \n" +
            $"Contiene solo lettere? {Alphabeto(StringIn.Text)} \n" +
            $"Contiene solo lettere e numeri? {Alphanumer(StringIn.Text)} \n" +
            $"E' palidroma? {Palin(StringIn.Text)} \n" +
            $"Reverse: {Contrariotxt(StringIn.Text)} \n" +
            $"Quante lettere: {Parole(StringIn.Text)} \n";

    }
}





