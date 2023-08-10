using System.Reflection;

namespace File_Hosting.Models
{
	public class Utils
	{
		public static string pathDir = Path.Combine(Path.GetDirectoryName(Assembly.GetEntryAssembly().Location), @"App_Files");

		public static string ToKb(long b)
		{
			double kb = b / 1024;
			string result = Math.Round(kb).ToString();
			return result;
		}

		public static List<FileUpload> GetFilesUpload()
		{
			if (!Directory.Exists(pathDir)) 
				Directory.CreateDirectory(pathDir);

			List<FileUpload> result = new List<FileUpload>();
			DirectoryInfo RetCat = new DirectoryInfo(pathDir);
			
			if (RetCat.GetFiles().Count() > 0)
			{
				foreach (FileInfo aFile in RetCat.GetFiles())
				{
					result.Add(new FileUpload() { FileName = aFile.Name, Size = aFile.Length, DateLoad = aFile.LastWriteTime });
				}
			}

			return result.OrderByDescending(x => x.DateLoad).ToList();
		}
	}
}
