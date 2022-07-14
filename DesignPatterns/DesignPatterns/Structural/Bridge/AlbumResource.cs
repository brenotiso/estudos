namespace DesignPatterns.Structural.Bridge
{
    internal class AlbumResource : IResource
    {
        private readonly Album _album;

        public AlbumResource(Album album) => _album = album;

        public string GetComplement() =>
            $"With {_album.Songs} songs ({_album.Minutes} minutes)";

        public string GetInfo() => $"{_album.Band}, {_album.Year}";

        public string GetName() => _album.Title;
    }
}
