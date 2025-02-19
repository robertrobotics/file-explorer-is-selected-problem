using System.Collections.ObjectModel;

namespace FileExplorerTest.ViewModels
{
    public class FilesListViewModel
    {
        public ObservableCollection<FileItem> Files { get; set; }

        public FilesListViewModel()
        {
            Files = new ObservableCollection<FileItem>
        {
            new FileItem { Path = @"D:\Folder\plik1.png" },
            new FileItem { Path = @"D:\Folder\plik2.png" },
            new FileItem { Path = @"D:\Folder\plik3.png" }
        };
        }
    }
}
