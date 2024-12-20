toc.dat                                                                                             0000600 0004000 0002000 00000023452 14717562640 0014461 0                                                                                                    ustar 00postgres                        postgres                        0000000 0000000                                                                                                                                                                        PGDMP   ,    /            
    |            Movie    16.3    16.3 '               0    0    ENCODING    ENCODING        SET client_encoding = 'UTF8';
                      false                    0    0 
   STDSTRINGS 
   STDSTRINGS     (   SET standard_conforming_strings = 'on';
                      false                    0    0 
   SEARCHPATH 
   SEARCHPATH     8   SELECT pg_catalog.set_config('search_path', '', false);
                      false                    1262    33037    Movie    DATABASE     �   CREATE DATABASE "Movie" WITH TEMPLATE = template0 ENCODING = 'UTF8' LOCALE_PROVIDER = libc LOCALE = 'English_United States.1252';
    DROP DATABASE "Movie";
                postgres    false         �            1259    33039    admin    TABLE     �   CREATE TABLE public.admin (
    id integer NOT NULL,
    nama character varying(30) NOT NULL,
    no_hp character varying(30) NOT NULL,
    username character varying(30) NOT NULL,
    password character varying(30) NOT NULL
);
    DROP TABLE public.admin;
       public         heap    postgres    false         �            1259    33038    admin_id_seq    SEQUENCE     �   CREATE SEQUENCE public.admin_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 #   DROP SEQUENCE public.admin_id_seq;
       public          postgres    false    216                    0    0    admin_id_seq    SEQUENCE OWNED BY     =   ALTER SEQUENCE public.admin_id_seq OWNED BY public.admin.id;
          public          postgres    false    215         �            1259    33067    film    TABLE     �   CREATE TABLE public.film (
    id_film integer NOT NULL,
    nama_film character varying(20) NOT NULL,
    id_genre integer NOT NULL
);
    DROP TABLE public.film;
       public         heap    postgres    false         �            1259    33076    film_    TABLE     �   CREATE TABLE public.film_ (
    id integer NOT NULL,
    nama character varying(30) NOT NULL,
    tahun_rilis character varying(30) NOT NULL,
    id_genre integer NOT NULL
);
    DROP TABLE public.film_;
       public         heap    postgres    false         �            1259    33075    film__id_seq    SEQUENCE     �   CREATE SEQUENCE public.film__id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 #   DROP SEQUENCE public.film__id_seq;
       public          postgres    false    224                    0    0    film__id_seq    SEQUENCE OWNED BY     =   ALTER SEQUENCE public.film__id_seq OWNED BY public.film_.id;
          public          postgres    false    223         �            1259    33066    film_id_film_seq    SEQUENCE     �   CREATE SEQUENCE public.film_id_film_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 '   DROP SEQUENCE public.film_id_film_seq;
       public          postgres    false    222                    0    0    film_id_film_seq    SEQUENCE OWNED BY     E   ALTER SEQUENCE public.film_id_film_seq OWNED BY public.film.id_film;
          public          postgres    false    221         �            1259    33060    genre    TABLE     l   CREATE TABLE public.genre (
    id_genre integer NOT NULL,
    nama_genre character varying(30) NOT NULL
);
    DROP TABLE public.genre;
       public         heap    postgres    false         �            1259    33059    genre_id_genre_seq    SEQUENCE     �   CREATE SEQUENCE public.genre_id_genre_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 )   DROP SEQUENCE public.genre_id_genre_seq;
       public          postgres    false    220                    0    0    genre_id_genre_seq    SEQUENCE OWNED BY     I   ALTER SEQUENCE public.genre_id_genre_seq OWNED BY public.genre.id_genre;
          public          postgres    false    219         �            1259    33053    movie    TABLE     �   CREATE TABLE public.movie (
    id integer NOT NULL,
    nama character varying(30) NOT NULL,
    tahun_rilis timestamp without time zone NOT NULL,
    id_genre integer NOT NULL
);
    DROP TABLE public.movie;
       public         heap    postgres    false         �            1259    33052    movie_id_seq    SEQUENCE     �   CREATE SEQUENCE public.movie_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 #   DROP SEQUENCE public.movie_id_seq;
       public          postgres    false    218                    0    0    movie_id_seq    SEQUENCE OWNED BY     =   ALTER SEQUENCE public.movie_id_seq OWNED BY public.movie.id;
          public          postgres    false    217         d           2604    33042    admin id    DEFAULT     d   ALTER TABLE ONLY public.admin ALTER COLUMN id SET DEFAULT nextval('public.admin_id_seq'::regclass);
 7   ALTER TABLE public.admin ALTER COLUMN id DROP DEFAULT;
       public          postgres    false    215    216    216         g           2604    33070    film id_film    DEFAULT     l   ALTER TABLE ONLY public.film ALTER COLUMN id_film SET DEFAULT nextval('public.film_id_film_seq'::regclass);
 ;   ALTER TABLE public.film ALTER COLUMN id_film DROP DEFAULT;
       public          postgres    false    222    221    222         h           2604    33079    film_ id    DEFAULT     d   ALTER TABLE ONLY public.film_ ALTER COLUMN id SET DEFAULT nextval('public.film__id_seq'::regclass);
 7   ALTER TABLE public.film_ ALTER COLUMN id DROP DEFAULT;
       public          postgres    false    223    224    224         f           2604    33063    genre id_genre    DEFAULT     p   ALTER TABLE ONLY public.genre ALTER COLUMN id_genre SET DEFAULT nextval('public.genre_id_genre_seq'::regclass);
 =   ALTER TABLE public.genre ALTER COLUMN id_genre DROP DEFAULT;
       public          postgres    false    219    220    220         e           2604    33056    movie id    DEFAULT     d   ALTER TABLE ONLY public.movie ALTER COLUMN id SET DEFAULT nextval('public.movie_id_seq'::regclass);
 7   ALTER TABLE public.movie ALTER COLUMN id DROP DEFAULT;
       public          postgres    false    217    218    218                   0    33039    admin 
   TABLE DATA           D   COPY public.admin (id, nama, no_hp, username, password) FROM stdin;
    public          postgres    false    216       4867.dat 	          0    33067    film 
   TABLE DATA           <   COPY public.film (id_film, nama_film, id_genre) FROM stdin;
    public          postgres    false    222       4873.dat           0    33076    film_ 
   TABLE DATA           @   COPY public.film_ (id, nama, tahun_rilis, id_genre) FROM stdin;
    public          postgres    false    224       4875.dat           0    33060    genre 
   TABLE DATA           5   COPY public.genre (id_genre, nama_genre) FROM stdin;
    public          postgres    false    220       4871.dat           0    33053    movie 
   TABLE DATA           @   COPY public.movie (id, nama, tahun_rilis, id_genre) FROM stdin;
    public          postgres    false    218       4869.dat            0    0    admin_id_seq    SEQUENCE SET     :   SELECT pg_catalog.setval('public.admin_id_seq', 2, true);
          public          postgres    false    215                    0    0    film__id_seq    SEQUENCE SET     :   SELECT pg_catalog.setval('public.film__id_seq', 9, true);
          public          postgres    false    223                    0    0    film_id_film_seq    SEQUENCE SET     >   SELECT pg_catalog.setval('public.film_id_film_seq', 1, true);
          public          postgres    false    221                    0    0    genre_id_genre_seq    SEQUENCE SET     @   SELECT pg_catalog.setval('public.genre_id_genre_seq', 1, true);
          public          postgres    false    219                    0    0    movie_id_seq    SEQUENCE SET     ;   SELECT pg_catalog.setval('public.movie_id_seq', 1, false);
          public          postgres    false    217         j           2606    33044    admin admin_pkey 
   CONSTRAINT     N   ALTER TABLE ONLY public.admin
    ADD CONSTRAINT admin_pkey PRIMARY KEY (id);
 :   ALTER TABLE ONLY public.admin DROP CONSTRAINT admin_pkey;
       public            postgres    false    216         r           2606    33081    film_ film__pkey 
   CONSTRAINT     N   ALTER TABLE ONLY public.film_
    ADD CONSTRAINT film__pkey PRIMARY KEY (id);
 :   ALTER TABLE ONLY public.film_ DROP CONSTRAINT film__pkey;
       public            postgres    false    224         p           2606    33072    film film_pkey 
   CONSTRAINT     Q   ALTER TABLE ONLY public.film
    ADD CONSTRAINT film_pkey PRIMARY KEY (id_film);
 8   ALTER TABLE ONLY public.film DROP CONSTRAINT film_pkey;
       public            postgres    false    222         n           2606    33065    genre genre_pkey 
   CONSTRAINT     T   ALTER TABLE ONLY public.genre
    ADD CONSTRAINT genre_pkey PRIMARY KEY (id_genre);
 :   ALTER TABLE ONLY public.genre DROP CONSTRAINT genre_pkey;
       public            postgres    false    220         l           2606    33058    movie movie_pkey 
   CONSTRAINT     N   ALTER TABLE ONLY public.movie
    ADD CONSTRAINT movie_pkey PRIMARY KEY (id);
 :   ALTER TABLE ONLY public.movie DROP CONSTRAINT movie_pkey;
       public            postgres    false    218                                                                                                                                                                                                                              4867.dat                                                                                            0000600 0004000 0002000 00000000073 14717562640 0014276 0                                                                                                    ustar 00postgres                        postgres                        0000000 0000000                                                                                                                                                                        2	Andre Firmansyah	232410101037	Andre123okey	andre213
\.


                                                                                                                                                                                                                                                                                                                                                                                                                                                                     4873.dat                                                                                            0000600 0004000 0002000 00000000017 14717562640 0014271 0                                                                                                    ustar 00postgres                        postgres                        0000000 0000000                                                                                                                                                                        1	Andre	1
\.


                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                 4875.dat                                                                                            0000600 0004000 0002000 00000000255 14717562640 0014277 0                                                                                                    ustar 00postgres                        postgres                        0000000 0000000                                                                                                                                                                        2	andre	02/02/2004	1
3	andre	02/02/2004	1
4	andre	02/02/2004	1
5	andre	02/02/2004	1
6	andre	02/02/2004	1
7	andre	02/02/2004	1
8	andre	02/02/2004	1
9	andre	02/02/2004	1
\.


                                                                                                                                                                                                                                                                                                                                                   4871.dat                                                                                            0000600 0004000 0002000 00000000016 14717562640 0014266 0                                                                                                    ustar 00postgres                        postgres                        0000000 0000000                                                                                                                                                                        1	Horror
\.


                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                  4869.dat                                                                                            0000600 0004000 0002000 00000000005 14717562640 0014273 0                                                                                                    ustar 00postgres                        postgres                        0000000 0000000                                                                                                                                                                        \.


                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                           restore.sql                                                                                         0000600 0004000 0002000 00000020422 14717562640 0015400 0                                                                                                    ustar 00postgres                        postgres                        0000000 0000000                                                                                                                                                                        --
-- NOTE:
--
-- File paths need to be edited. Search for $$PATH$$ and
-- replace it with the path to the directory containing
-- the extracted data files.
--
--
-- PostgreSQL database dump
--

-- Dumped from database version 16.3
-- Dumped by pg_dump version 16.3

SET statement_timeout = 0;
SET lock_timeout = 0;
SET idle_in_transaction_session_timeout = 0;
SET client_encoding = 'UTF8';
SET standard_conforming_strings = on;
SELECT pg_catalog.set_config('search_path', '', false);
SET check_function_bodies = false;
SET xmloption = content;
SET client_min_messages = warning;
SET row_security = off;

DROP DATABASE "Movie";
--
-- Name: Movie; Type: DATABASE; Schema: -; Owner: postgres
--

CREATE DATABASE "Movie" WITH TEMPLATE = template0 ENCODING = 'UTF8' LOCALE_PROVIDER = libc LOCALE = 'English_United States.1252';


ALTER DATABASE "Movie" OWNER TO postgres;

\connect "Movie"

SET statement_timeout = 0;
SET lock_timeout = 0;
SET idle_in_transaction_session_timeout = 0;
SET client_encoding = 'UTF8';
SET standard_conforming_strings = on;
SELECT pg_catalog.set_config('search_path', '', false);
SET check_function_bodies = false;
SET xmloption = content;
SET client_min_messages = warning;
SET row_security = off;

SET default_tablespace = '';

SET default_table_access_method = heap;

--
-- Name: admin; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.admin (
    id integer NOT NULL,
    nama character varying(30) NOT NULL,
    no_hp character varying(30) NOT NULL,
    username character varying(30) NOT NULL,
    password character varying(30) NOT NULL
);


ALTER TABLE public.admin OWNER TO postgres;

--
-- Name: admin_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.admin_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER SEQUENCE public.admin_id_seq OWNER TO postgres;

--
-- Name: admin_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.admin_id_seq OWNED BY public.admin.id;


--
-- Name: film; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.film (
    id_film integer NOT NULL,
    nama_film character varying(20) NOT NULL,
    id_genre integer NOT NULL
);


ALTER TABLE public.film OWNER TO postgres;

--
-- Name: film_; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.film_ (
    id integer NOT NULL,
    nama character varying(30) NOT NULL,
    tahun_rilis character varying(30) NOT NULL,
    id_genre integer NOT NULL
);


ALTER TABLE public.film_ OWNER TO postgres;

--
-- Name: film__id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.film__id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER SEQUENCE public.film__id_seq OWNER TO postgres;

--
-- Name: film__id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.film__id_seq OWNED BY public.film_.id;


--
-- Name: film_id_film_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.film_id_film_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER SEQUENCE public.film_id_film_seq OWNER TO postgres;

--
-- Name: film_id_film_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.film_id_film_seq OWNED BY public.film.id_film;


--
-- Name: genre; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.genre (
    id_genre integer NOT NULL,
    nama_genre character varying(30) NOT NULL
);


ALTER TABLE public.genre OWNER TO postgres;

--
-- Name: genre_id_genre_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.genre_id_genre_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER SEQUENCE public.genre_id_genre_seq OWNER TO postgres;

--
-- Name: genre_id_genre_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.genre_id_genre_seq OWNED BY public.genre.id_genre;


--
-- Name: movie; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.movie (
    id integer NOT NULL,
    nama character varying(30) NOT NULL,
    tahun_rilis timestamp without time zone NOT NULL,
    id_genre integer NOT NULL
);


ALTER TABLE public.movie OWNER TO postgres;

--
-- Name: movie_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.movie_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER SEQUENCE public.movie_id_seq OWNER TO postgres;

--
-- Name: movie_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.movie_id_seq OWNED BY public.movie.id;


--
-- Name: admin id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.admin ALTER COLUMN id SET DEFAULT nextval('public.admin_id_seq'::regclass);


--
-- Name: film id_film; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.film ALTER COLUMN id_film SET DEFAULT nextval('public.film_id_film_seq'::regclass);


--
-- Name: film_ id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.film_ ALTER COLUMN id SET DEFAULT nextval('public.film__id_seq'::regclass);


--
-- Name: genre id_genre; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.genre ALTER COLUMN id_genre SET DEFAULT nextval('public.genre_id_genre_seq'::regclass);


--
-- Name: movie id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.movie ALTER COLUMN id SET DEFAULT nextval('public.movie_id_seq'::regclass);


--
-- Data for Name: admin; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.admin (id, nama, no_hp, username, password) FROM stdin;
\.
COPY public.admin (id, nama, no_hp, username, password) FROM '$$PATH$$/4867.dat';

--
-- Data for Name: film; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.film (id_film, nama_film, id_genre) FROM stdin;
\.
COPY public.film (id_film, nama_film, id_genre) FROM '$$PATH$$/4873.dat';

--
-- Data for Name: film_; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.film_ (id, nama, tahun_rilis, id_genre) FROM stdin;
\.
COPY public.film_ (id, nama, tahun_rilis, id_genre) FROM '$$PATH$$/4875.dat';

--
-- Data for Name: genre; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.genre (id_genre, nama_genre) FROM stdin;
\.
COPY public.genre (id_genre, nama_genre) FROM '$$PATH$$/4871.dat';

--
-- Data for Name: movie; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.movie (id, nama, tahun_rilis, id_genre) FROM stdin;
\.
COPY public.movie (id, nama, tahun_rilis, id_genre) FROM '$$PATH$$/4869.dat';

--
-- Name: admin_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.admin_id_seq', 2, true);


--
-- Name: film__id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.film__id_seq', 9, true);


--
-- Name: film_id_film_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.film_id_film_seq', 1, true);


--
-- Name: genre_id_genre_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.genre_id_genre_seq', 1, true);


--
-- Name: movie_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.movie_id_seq', 1, false);


--
-- Name: admin admin_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.admin
    ADD CONSTRAINT admin_pkey PRIMARY KEY (id);


--
-- Name: film_ film__pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.film_
    ADD CONSTRAINT film__pkey PRIMARY KEY (id);


--
-- Name: film film_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.film
    ADD CONSTRAINT film_pkey PRIMARY KEY (id_film);


--
-- Name: genre genre_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.genre
    ADD CONSTRAINT genre_pkey PRIMARY KEY (id_genre);


--
-- Name: movie movie_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.movie
    ADD CONSTRAINT movie_pkey PRIMARY KEY (id);


--
-- PostgreSQL database dump complete
--

                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                              