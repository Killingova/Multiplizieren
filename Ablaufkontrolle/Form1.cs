namespace Ablaufkontrolle
{
    // Die Hauptklasse für das Formular in einer Windows Forms Anwendung.
    public partial class Form1 : Form
    {
        // Ein Zufallszahlengenerator, der für die Erstellung von Multiplikationsaufgaben verwendet wird.
        private Random zahl = new Random();
        // Variable zur Speicherung der korrekten Antwort der aktuellen Multiplikationsaufgabe.
        private int correctAnswer;

        // Der Konstruktor des Formulars, der aufgerufen wird, wenn eine Instanz der Klasse erstellt wird.
        public Form1()
        {
            // Initialisiert die Komponenten des Formulars (automatisch generierter Code).
            InitializeComponent();
            // Ruft die Methode auf, um eine neue Multiplikationsaufgabe zu generieren, sobald das Formular geladen wird.
            GenerateNewProblem();
        }

        // Methode zur Generierung einer neuen Multiplikationsaufgabe.
        private void GenerateNewProblem()
        {
            // Erzeugt zwei Zufallszahlen zwischen 1 und 9.
            int kisten = zahl.Next(1, 10); // Erste Zahl
            int flaschen = zahl.Next(1, 10); // Zweite Zahl

            // Berechnet das Produkt der beiden Zahlen und speichert es als die korrekte Antwort.
            correctAnswer = kisten * flaschen;

            // Zeigt die Multiplikationsaufgabe in textBox1 an, ohne das Ergebnis preiszugeben.
            textBox1.Text = $"{kisten} * {flaschen} =  ";
        }

        // Event-Handler für den Button, der eine neue Aufgabe generiert.
        private void CmdZufallAufabe_Click(object sender, EventArgs e)
        {
            // Generiert eine neue Aufgabe.
            GenerateNewProblem();
            // Bereitet die Textfelder für die nächste Antwort und Nachricht vor, indem sie geleert werden.
            textBox2.Clear(); // Löscht den Inhalt des Antwort-Textfelds.
            textBox3.Clear(); // Löscht den Inhalt des Nachrichten-Textfelds.
        }

        // Event-Handler für den Button, der die Antwort überprüft.
        private void CmdErgenis_Click(object sender, EventArgs e)
        {
            // Ruft die Methode auf, um die vom Benutzer eingegebene Antwort zu überprüfen.
            CheckAnswer();
        }

        // Diese Methode wird benötigt, um das Paint-Event von PFarbe zu behandeln, ist hier aber nicht weiter implementiert.
        private void PFarbe_Paint(object sender, PaintEventArgs e)
        {
        }

        // Diese Methode wird benötigt, um das TextChanged-Event von textBox3 zu behandeln, ist hier aber nicht weiter implementiert.
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }

        // Methode zur Überprüfung der vom Benutzer eingegebenen Antwort.
        private void CheckAnswer()
        {
            // Versucht, die Eingabe des Benutzers in eine ganze Zahl zu konvertieren.
            bool isAnswerParsed = int.TryParse(textBox2.Text, out int userAnswer);

            if (isAnswerParsed)
            {
                // Wenn die Konversion erfolgreich war, wird überprüft, ob die Antwort korrekt ist.
                if (userAnswer == correctAnswer)
                {
                    // Wenn die Antwort richtig ist, wird der Hintergrund von PFarbe auf Grün gesetzt.
                    PFarbe.BackColor = Color.Green;
                    // Zeigt eine Bestätigungsnachricht an.
                    textBox3.Text = "Richtig!";
                }
                else
                {
                    // Wenn die Antwort falsch ist, wird der Hintergrund auf Rot gesetzt.
                    PFarbe.BackColor = Color.Red;
                    // Zeigt eine Fehlernachricht mit der richtigen Antwort an.
                    textBox3.Text = $"Falsch! Richtige Antwort: {correctAnswer}";
                }
            }
            else
            {
                // Wenn die Eingabe keine gültige Zahl ist, wird der Benutzer aufgefordert, eine gültige Zahl einzugeben.
                PFarbe.BackColor = Color.Red;
                textBox3.Text = "Bitte geben Sie eine gültige Zahl ein.";
            }
        }
    }
}
