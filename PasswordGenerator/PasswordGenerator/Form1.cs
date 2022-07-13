using System.Diagnostics;

namespace PasswordGenerator
{
    public partial class Form1 : Form
    {
        private readonly char[] upperCaseLetters = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
        private readonly char[] lowerCaseLetters = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
        private readonly char[] numberChars = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        private readonly char[] symbolChars = { '~', '`', '!', '?', '@', '#', '$', '%', '^', '&', '*', '(', ')', '-', '_', '=', '+', '[', ']', '{', '}', '.', '<', '>', '/', ':', ';' };

        private const int OPTIONS_AMOUNT = 4;

        public Form1()
        {
            InitializeComponent();
        }

        private void generateBtn_Click(object sender, EventArgs e)
        {
            // Declares list of arrays from above for later removal if needed
            List<char[]> optionsList = new() { upperCaseLetters, lowerCaseLetters, numberChars, symbolChars };
            // Declares array of booleans for options
            bool[] toggles = new bool[4];

            toggles[0] = includeUppercase.Checked;
            toggles[1] = includeLowercase.Checked;
            toggles[2] = includeNumbers.Checked;
            toggles[3] = includeSymbols.Checked;

            // Checks if no password length was inputted or if all the options are disabled
            if (string.IsNullOrEmpty(passLengthBox.Text) || (!toggles[0] && !toggles[1] && !toggles[2] && !toggles[3])) { return; }

            int passLength = Convert.ToInt32(passLengthBox.Text);

            // Loops through the options list and removes that option's array if the setting has it disabled
            int numRemoved = 0;
            for (int i = 0; i < OPTIONS_AMOUNT; i++)
            {
                if (!toggles[i])
                {
                    optionsList.RemoveAt(i - numRemoved);
                    numRemoved++;
                }
            }

            // Creates new 'Random' class instance with a random seed using Guid hashcode
            Random random = new(Guid.NewGuid().GetHashCode());
            string generatedPass = "";

            // Loops through the amount of times determined by the password length
            // and randomly decides the chosen array and element
            for (int i = 0; i < passLength; i++)
            {
                char[] chosenAry = optionsList[random.Next(0, optionsList.Count)];
                char chosenChar = chosenAry[random.Next(0, chosenAry.Length)];

                generatedPass += chosenChar;
            }

            passBox.Text = generatedPass;
        }

        private void copyBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(passBox.Text)) { return; }

            string textToCopy = passBox.Text;

            Clipboard.SetText(textToCopy);
        }
    }
}