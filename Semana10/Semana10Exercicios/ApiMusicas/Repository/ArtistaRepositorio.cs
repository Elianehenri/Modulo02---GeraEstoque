using ApiMusicas.Models;

namespace ApiMusicas.Repository
{
    public class ArtistaRepositorio
    {
        private static int _indiceId = 1;
        private static List<Artista> _artistas = new();//listagem pra armazenar os artitas

        public Artista Criar(Artista artista)//metodo criar
        {

            artista.Id = _indiceId;

            _indiceId++;

            _artistas.Add(artista);

            return artista;
        }

        public Artista Atualizar(int id, Artista artista)//metodo atualizar
        {

            var artistaExistente = _artistas
                .FirstOrDefault(artistaLista => artistaLista.Id == id);

            if (artistaExistente == null) return null;//validaçao
            //atualizar os campos
            artistaExistente.Nome = artista.Nome;
            artistaExistente.NomeArtistico = artista.NomeArtistico;
            artistaExistente.PaisOrigem = artista.PaisOrigem;
            artistaExistente.FotoUrl = artista.FotoUrl;

            return artista;
        }

        public void Remover(int artistaId)//metodo remover
        {

            var artistaExistente = _artistas
                .FirstOrDefault(artistaLista => artistaLista.Id == artistaId);

            _artistas.Remove(artistaExistente);
        }

        public List<Artista> ObterTodos(string filtro)//retorna uma lista de artistas no total
        {
            if (!string.IsNullOrEmpty(filtro))
            {
                return _artistas
                    .Where(a => a.Nome.Contains(filtro) || a.NomeArtistico.Contains(filtro))
                    .ToList();
            }

            return _artistas;
        }
        public Artista ObterPorId(int artistaId)
        {
            return _artistas.FirstOrDefault(a => a.Id == artistaId);
        }
        public Artista AtualizarFoto(int idArtista, string fotoUrl)
        {
            var artistaExistente = _artistas
                .FirstOrDefault(artistaLista => artistaLista.Id == idArtista);

            artistaExistente.FotoUrl = fotoUrl;

            return artistaExistente;
        }
    }
}
