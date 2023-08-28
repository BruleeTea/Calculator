using System.Data;
namespace Calaculator
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }
        /// <summary>
        ///  Displays the number/operation that was clicked into the textbox
        /// </summary>
        /// <param name="sender">reference the button that was clicked</param>
        /// <param name="e">contains the event data</param>
        private void Button_Click(object sender, EventArgs e)
        {
            if (result.Text == "0" || result.Text == "Error")
                Clear(sender, e);
            Button button = (Button)sender;
            result.Text = result.Text + button.Text; //Puts whatever number/operation the user clicked into the textbox
        }
        /// <summary>
        ///  Clears the textbox
        /// </summary>
        /// <param name="sender">reference the button that was clicked</param>
        /// <param name="e">contains the event data</param
        private void Clear(object sender, EventArgs e)
        {
            result.Clear();
        }

        /// <summary>
        ///  Displays the equation on a label and shows the result in the textbox. 
        /// </summary>
        /// <param name="sender">reference the button that was clicked</param>
        /// <param name="e">contains the event data</param
        private void Equals_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            equation.Text = result.Text; //Displays the equation on a label
            try
            {
                result.Text = dt.Compute(result.Text.ToString(), "").ToString(); //Calculate given equation from the textbox
            }
            catch
            {
                result.Text = "Error"; // Display error if user inputs an invalid equation/syntex error
            }
        }
    }
}