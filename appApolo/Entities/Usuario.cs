namespace UTN.Winforms.Apolo.Entities
{
    class Usuario
    {
        //public byte[] Fotografia { get; set; } //TODO
        public string Fotografia { get; set; }
        public string IdUsuario { set; get; }
        public string Nombre { set; get; }
        public string Apellidos { set; get; }
        public string NombreUsuario { set; get; }
        public string Contrasenna { set; get; }
        public int TipoPerfil { set; get; }

        //Admin de la DB
        public string Login { set; get; }
        public string Password { set; get; }
    }
}
