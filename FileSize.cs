using System;
using System.IO;

class FileSize
{
	public static void Main(string[] args)
	{
		if(args.Length > 0)
		{
			if(args.Length == 1 && args[0] == "-h")
			{
				Console.WriteLine("HELP COMMAND - Information");
				Console.WriteLine("-n | name : File name");
			}
			else if(args.Length == 2 && (args[0] == "-n" || args[0] == "name"))
			{
				string[] sizes = {"B", "KB", "MB", "GB", "TB"};
				double len = new FileInfo(args[1]).Length;
				int order = 0;
				while(len >= 1024 && order < sizes.Length - 1)
				{
					order ++;
					len = len / 1024;
				}
				string result = string.Format("{0:0.##}{1}", len, sizes[order]);
				Console.WriteLine("Size: "+result);
			}
		}
	}
}