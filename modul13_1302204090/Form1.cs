namespace modul13_1302204090
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void buttonSubmit_Click(object sender, EventArgs e)
		{
			string username = textBox_username.Text;
			string filePath = textBox_filePath.Text;

			if (username != null && filePath != null)
			{
				if (username.Length > 0 && filePath.Length > 0)
				{
					bool isSafe = 
						!IsContainsSpecialCharacter(username) && !IsContainsSpecialCharacter(filePath) &&
						!IsUsingFileStreamPath(filePath) &&
						!IsFilePathIsMoreThanTwo(filePath);

					if (isSafe)
					{
						label_output.Text = "Output: Username dan FilePath Aman";
					}
					else
					{
						label_output.Text = "Output: Username dan FilePath Tidak Aman";
					}
				}
			}
		}

		public bool IsUsingFileStreamPath(string filePath)
		{
			return filePath.StartsWith("filename::");
		}

		public bool IsContainsSpecialCharacter(string text)
		{
			return text.Contains("*") || text.Contains("@") ||
				text.Contains("%") || text.Contains("~");
		}

		public bool IsFilePathIsMoreThanTwo(string filePath)
		{
			string[] childPath = filePath.Split('\\');
			Console.WriteLine(childPath.Length);
			return childPath.Length > 2;
		}
	}
}