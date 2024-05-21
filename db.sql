--
-- PostgreSQL database dump
--

-- Dumped from database version 16.3 (Debian 16.3-1.pgdg120+1)
-- Dumped by pg_dump version 16.2

-- Started on 2024-05-21 21:50:36 CEST

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
-- TOC entry 216 (class 1259 OID 16441)
-- Name: Persons; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public."Persons" (
    "Id" uuid NOT NULL,
    "FirstName" character varying(25) NOT NULL,
    "LastName" character varying(25) NOT NULL,
    "Age" integer NOT NULL
);


ALTER TABLE public."Persons" OWNER TO postgres;

--
-- TOC entry 215 (class 1259 OID 16436)
-- Name: __EFMigrationsHistory; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public."__EFMigrationsHistory" (
    "MigrationId" character varying(150) NOT NULL,
    "ProductVersion" character varying(32) NOT NULL
);


ALTER TABLE public."__EFMigrationsHistory" OWNER TO postgres;

--
-- TOC entry 3354 (class 0 OID 16441)
-- Dependencies: 216
-- Data for Name: Persons; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public."Persons" ("Id", "FirstName", "LastName", "Age") FROM stdin;
1ba52776-ccea-492d-8089-396b3221ca5e	Vlad	Syzov	20
2d6cbbd6-5758-4530-84c4-a93bde91e330	string	string	0
\.


--
-- TOC entry 3353 (class 0 OID 16436)
-- Dependencies: 215
-- Data for Name: __EFMigrationsHistory; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public."__EFMigrationsHistory" ("MigrationId", "ProductVersion") FROM stdin;
20240521185352_InitialCreate	8.0.5
20240521185857_Configure	8.0.5
\.


--
-- TOC entry 3209 (class 2606 OID 16447)
-- Name: Persons PK_Persons; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."Persons"
    ADD CONSTRAINT "PK_Persons" PRIMARY KEY ("Id");


--
-- TOC entry 3207 (class 2606 OID 16440)
-- Name: __EFMigrationsHistory PK___EFMigrationsHistory; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."__EFMigrationsHistory"
    ADD CONSTRAINT "PK___EFMigrationsHistory" PRIMARY KEY ("MigrationId");


-- Completed on 2024-05-21 21:50:36 CEST

--
-- PostgreSQL database dump complete
--

