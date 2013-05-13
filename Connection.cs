namespace PWServer.Core.Network
{
    using PWServer.Core.Network.Cryptography;
    using System;
    using System.Collections.Generic;
    using System.Net.Sockets;

    public class Connection
    {
        public int AccessLevel = 0;
        public bool AccountActivated = false;
        public int AccountID = 0;
        public byte[] Buffer;
        public List<CharacterSlot> Characters = new List<CharacterSlot>();
        public int CharID = 0;
        public byte[] ClientKey = null;
        public RC4Cipher Crypter;
        public int CubiGold = 0;
        public bool Disconnect = false;
        public bool InGame = false;
        public byte[] Key1;
        public DateTime LastDate;
        public string LastIP = null;
        public int NextSlot = 0;
        public byte[] Password;
        public byte[] ServerKey = null;
        public int SessionID = 0;
        public System.Net.Sockets.Socket Socket;
        public byte[] UserName;
    }
}

