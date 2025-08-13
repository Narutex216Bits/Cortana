CREATE DATABASE otames_sql;

USE otames_db;

CREATE TABLE anime (
  id int(11) NOT NULL,
  nome varchar(255) NOT NULL,
  titulo_alternativo varchar(255) DEFAULT NULL,
  data_lancamento date NOT NULL,
  data_termino date DEFAULT NULL,
  data_lancamento_br date DEFAULT NULL,
  criador varchar(255) DEFAULT NULL,
  diretor varchar(255) DEFAULT NULL,
  roteirista varchar(255) DEFAULT NULL,
  trilha_sonora varchar(255) DEFAULT NULL,
  estudio varchar(255) DEFAULT NULL,
  tipo varchar(50) DEFAULT NULL,
  status varchar(50) DEFAULT NULL,
  episodios int(11) DEFAULT NULL,
  duracao_media int(11) DEFAULT NULL,
  genero varchar(255) DEFAULT NULL,
  popularidade int(11) DEFAULT 0,
  nota_media decimal(3,1) DEFAULT NULL,
  numero_avaliacoes int(11) DEFAULT NULL,
  trailer_url text DEFAULT NULL,
  site_oficial text DEFAULT NULL,
  mal_id int(11) DEFAULT NULL,
  anilist_id int(11) DEFAULT NULL,
  inspiracao varchar(255) DEFAULT NULL,
  publico_alvo varchar(50) DEFAULT NULL,
  censura varchar(10) DEFAULT NULL,
  logo_url text DEFAULT NULL
);

CREATE TABLE anime_dubladores (
  id int(11) NOT NULL,
  nome varchar(255) NOT NULL,
  foto_url text DEFAULT NULL,
  data_aniversario date DEFAULT NULL
);

CREATE TABLE anime_personagens (
  id int(11) NOT NULL,
  nome varchar(255) NOT NULL,
  foto_url text DEFAULT NULL,
  anime_id int(11) NOT NULL,
  dublador_id int(11) NOT NULL
);

CREATE TABLE autores (
  id int(11) NOT NULL,
  nome_autor varchar(255) NOT NULL,
  biografia text DEFAULT NULL,
  foto_autor varchar(255) DEFAULT NULL,
  created_at timestamp NOT NULL DEFAULT current_timestamp()
);

CREATE TABLE autores_livros (
  id int(11) NOT NULL,
  autor_id int(11) NOT NULL,
  livro_id int(11) NOT NULL,
  created_at timestamp NOT NULL DEFAULT current_timestamp()
  );

CREATE TABLE compromissos (
  id int(11) NOT NULL,
  nome varchar(255) NOT NULL,
  descricao text DEFAULT NULL,
  data_compromisso date NOT NULL,
  hora_compromisso time NOT NULL,
  criado_em timestamp NOT NULL DEFAULT current_timestamp()
);

CREATE TABLE desenhos (
  id int(11) NOT NULL,
  nome varchar(255) NOT NULL,
  descricao text DEFAULT NULL,
  ano_lancamento int(11) DEFAULT NULL,
  imagem_url varchar(255) DEFAULT NULL,
  criado_em timestamp NOT NULL DEFAULT current_timestamp()
);

CREATE TABLE desenhos_dubladores (
  id int(11) NOT NULL,
  nome varchar(255) NOT NULL,
  descricao text DEFAULT NULL,
  imagem_url varchar(255) DEFAULT NULL,
  criado_em timestamp NOT NULL DEFAULT current_timestamp()
);

CREATE TABLE desenhos_personagens (
  id int(11) NOT NULL,
  nome varchar(255) NOT NULL,
  descricao text DEFAULT NULL,
  imagem_url varchar(255) DEFAULT NULL,
  dublador_id int(11) DEFAULT NULL,
  criado_em timestamp NOT NULL DEFAULT current_timestamp()
);

CREATE TABLE filmes (
  id int(11) NOT NULL,
  nome varchar(255) NOT NULL,
  sinopse text DEFAULT NULL,
  ano_lancamento year(4) DEFAULT NULL
);

CREATE TABLE filmes_atores (
  id int(11) NOT NULL,
  nome varchar(255) NOT NULL,
  foto_url text DEFAULT NULL,
  data_nascimento date DEFAULT NULL
);

CREATE TABLE filmes_personagens (
  id int(11) NOT NULL,
  nome varchar(255) NOT NULL,
  foto_url text DEFAULT NULL,
  filme_id int(11) NOT NULL,
  ator_id int(11) NOT NULL
);

CREATE TABLE jogos (
  id int(11) NOT NULL,
  nome varchar(255) NOT NULL,
  descricao text DEFAULT NULL,
  ano_lancamento year(4) DEFAULT NULL,
  url_capa text DEFAULT NULL
);

CREATE TABLE livros (
  id int(11) NOT NULL,
  titulo varchar(255) NOT NULL,
  ano_publicacao int(11) DEFAULT NULL,
  capa_url varchar(255) DEFAULT NULL,
  created_at timestamp NOT NULL DEFAULT current_timestamp()
);

CREATE TABLE musicas (
  id int(11) NOT NULL,
  nome varchar(255) NOT NULL,
  artista varchar(255) NOT NULL,
  ano_lancamento year(4) DEFAULT NULL,
  genero varchar(100) DEFAULT NULL,
  pais_origem varchar(100) DEFAULT NULL,
  url_video text DEFAULT NULL,
  descricao text DEFAULT NULL,
  tags text DEFAULT NULL,
  favorito tinyint(1) DEFAULT 0,
  foto_grupo varchar(255) DEFAULT NULL,
  foto_projeto varchar(255) DEFAULT NULL,
  logo varchar(255) DEFAULT NULL
);

CREATE TABLE personalidades (
  id int(11) NOT NULL,
  nome varchar(255) NOT NULL,
  area_atuacao varchar(255) DEFAULT NULL,
  biografia text DEFAULT NULL,
  nascimento date DEFAULT NULL,
  foto_url varchar(255) DEFAULT NULL,
  links_referencia text DEFAULT NULL,
  created_at timestamp NOT NULL DEFAULT current_timestamp()
);

CREATE TABLE series (
  id int(11) NOT NULL,
  nome varchar(255) NOT NULL,
  descricao text DEFAULT NULL,
  ano_lancamento int(11) NOT NULL,
  pais_origem varchar(255) DEFAULT NULL,
  genero varchar(255) DEFAULT NULL,
  foto_grupo varchar(255) DEFAULT NULL,
  foto_projeto varchar(255) DEFAULT NULL,
  logo varchar(255) DEFAULT NULL,
  url_video varchar(255) DEFAULT NULL,
  tags varchar(255) DEFAULT NULL,
  created_at timestamp NOT NULL DEFAULT current_timestamp()
);

CREATE TABLE series_atores (
  id int(11) NOT NULL,
  nome_ator varchar(255) NOT NULL,
  personagem varchar(255) NOT NULL,
  id_serie int(11) NOT NULL,
  foto_ator varchar(255) DEFAULT NULL,
  aniversario date DEFAULT NULL,
  created_at timestamp NOT NULL DEFAULT current_timestamp()
);

CREATE TABLE tokusatsu (
  id int(11) NOT NULL,
  nome varchar(255) NOT NULL,
  logo_url text DEFAULT NULL
);

CREATE TABLE tokusatsu_personagens (
  id int(11) NOT NULL,
  nome varchar(255) NOT NULL,
  foto_url text DEFAULT NULL,
  tokusatsu_id int(11) NOT NULL,
  ator_id int(11) NOT NULL
);

CREATE TABLE users (
  id INT(3) NOT NULL,
  login varchar(15) NOT NULL,
  senha varchar (30) NOT NULL
);