namespace Winforms.Services;

internal class WindowsFileSystem : IFileSystemProvider
{
    public OpenFileDialog OpenFile() =>
        new()
        {
            InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal),
            Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"
        };
}
