using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA2
{
    class StackNode
    {
        // ATTRIBUTES
        private String _album;          // name of album
        private String _artist;         // name of artist
        private int _noOfTracks;        // number of tracks on album
        private int _duration;          // duration of album
        private StackNode _previous;    // previous node

        // BEHAVIOURS
        // constructor
        public StackNode(String albumName, String artistName)
        {
            _album = albumName;
            _artist = artistName;
            _noOfTracks = 0;
            _duration = 0;
            _previous = null;
        }// constructor

        public String album
        {
            get
            {
                return _album;
            }
            set
            {
                _album = value;
            }
        }

        public String artist
        {
            get
            {
                return _artist;
            }
            set
            {
                _artist = value;
            }
        }

        public int noOfTracks
        {
            get
            {
                return _noOfTracks;
            }
            set
            {
                _noOfTracks = value;
            }
        }

        public StackNode previous
        {
            get
            {
                return _previous;
            }
            set
            {
                _previous = value;
            }
        }

        public int duration
        {
            get
            {
                return _duration;
            }
            set
            {
                _duration = value;
            }
        }
    }
}
