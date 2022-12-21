using Spotify.Abstraction;
using Spotify.Models;
using Spotify.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotify.Context
{
    internal class ContexT
    {
        IService<Artist> _artist;
        IService<Music> _music;
        IService<MusicArtist> _musicArtist;
        IService<Role> _role;
        IService<Category> _category;
        IService<Playlist> _playlist;
        IService<Playlistname> _playlistname;
        IService<User> _user;
        public IService<Artist> Artist
        {
            get
            {
                if (_artist == null)
                {
                    _artist = new ArtistService();
                }
                return _artist;
            }
        }
        public IService<Music> Music
        {
            get
            {
                if (_music == null)
                {
                    _music = new MusicService();
                }
                return _music;
            }
        }
        public IService<MusicArtist> MusicArtist
        {
            get
            {
                if (_musicArtist == null)
                {
                    _musicArtist = new MusicArtistService();
                }
                return _musicArtist;
            }
        }
        public IService<Role> Role
        {
            get
            {
                if (_role == null)
                {
                    _role = new RoleService();
                }
                return _role;
            }
        }
        public IService<Category> Category
        {
            get
            {
                if (_category == null)
                {
                    _category = new CategoryService();
                }
                return _category;
            }
        }
        public IService<Playlist> Playlist
        {
            get
            {
                if (_playlist == null)
                {
                    _playlist = new PlaylistService();
                }
                return _playlist;
            }
        }
        public IService<Playlistname> Playlistname
        {
            get
            {
                if (_playlistname == null)
                {
                    _playlistname = new PlaylistnameService();
                }
                return _playlistname;
            }
        }

        public IService<User> User
        {
            get
            {
                if (_user == null)
                {
                    _user = new UserService();
                }
                return _user;
            }
        }
    }
}
