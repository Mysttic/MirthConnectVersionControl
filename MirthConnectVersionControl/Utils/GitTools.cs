using LibGit2Sharp;
using System.Data.Common;

namespace MirthConnectVersionControl.Utils
{
	public static class GitTools
	{
		private static MainForm form;
		private static string databaseType;

		/// <summary>
		/// Create a new change in the repository
		/// </summary>
		/// <param name="_form"></param>
		/// <param name="reader"></param>
		public static void GitChange(MainForm _form, DbDataReader reader, string _databaseType)
		{
			form = _form;
			databaseType = _databaseType.Replace("Listener", "");
			GitChange(id: reader[0].ToString() ?? "", name: reader[1].ToString() ?? "", revision: reader[2].ToString() ?? "", content: reader[3].ToString() ?? "");
		}

		/// <summary>
		/// Create a new change in the repository
		/// </summary>
		/// <param name="id"></param>
		/// <param name="name"></param>
		/// <param name="revision"></param>
		/// <param name="content"></param>
		private static void GitChange(string id, string name, string revision, string content)
		{
			if (!Path.Exists(Path.Combine(Properties.Settings.Default.RepoPath, databaseType)))
				Directory.CreateDirectory(Path.Combine(Properties.Settings.Default.RepoPath, databaseType));
			string filePath = Path.Combine(
				Properties.Settings.Default.RepoPath,
				databaseType,
				name + (Properties.Settings.Default.UseGit ? "" : $"_{DateTime.Now.ToString().Replace('.', '_').Replace(':', '_')}_Rev{revision}"));
			File.WriteAllText(filePath, content);

			if (Properties.Settings.Default.UseGit)
			{
				// Check, if repository exists
				if (!Repository.IsValid(Properties.Settings.Default.RepoPath))				
					GitNewRepo(Properties.Settings.Default.RepoPath);				
				GitStage(filePath);
				if (HasChanges())				
					GitCommit(name);
				
			}
		}

		/// <summary>
		/// Get the repository from the path
		/// </summary>
		/// <returns></returns>
		private static Repository GetRepoFromPath()
		{
			return new Repository(Properties.Settings.Default.RepoPath);
		}

		/// <summary>
		/// Create a new repository
		/// </summary>
		/// <param name="path"></param>
		private static void GitNewRepo(string path)
		{
			Repository.Init(path);
			LogTools.Log(form, $"New repository created at {Properties.Settings.Default.RepoPath}");
		}

		/// <summary>
		/// Stage the changes in the repository
		/// </summary>
		/// <param name="path"></param>
		private static void GitStage(string path)
		{
			using (var repo = GetRepoFromPath())
			{
				Commands.Stage(repo, path);
			}
		}
		
		/// <summary>
		/// Commit the changes in the repository
		/// </summary>
		/// <param name="message"></param>
		private static void GitCommit(string message)
		{
			using (var repo = GetRepoFromPath())
			{
				// Get the author and committer details
				var author = new Signature("MCVC", "mcvc@mcvc.com", DateTime.Now);
				var committer = author;

				// Commit the staged changes
				repo.Commit(message, author, committer);	
				LogTools.Log(form, $"Changes commited: {message}");

			}
		}

		/// <summary>
		/// Check if there are any changes in the repository
		/// </summary>
		/// <returns></returns>
		private static bool HasChanges()
		{
			using (var repo = GetRepoFromPath())
			{
				// Check for changes
				var changes = repo.Diff.Compare<TreeChanges>(repo.Head.Tip.Tree, DiffTargets.Index);
				return changes.Count > 0;
			}
		}
				
	}
}
