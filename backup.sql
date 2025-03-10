PGDMP          
            }            Partners    17.2    17.2 +    �           0    0    ENCODING    ENCODING        SET client_encoding = 'UTF8';
                           false            �           0    0 
   STDSTRINGS 
   STDSTRINGS     (   SET standard_conforming_strings = 'on';
                           false            �           0    0 
   SEARCHPATH 
   SEARCHPATH     8   SELECT pg_catalog.set_config('search_path', '', false);
                           false            �           1262    16388    Partners    DATABASE     ~   CREATE DATABASE "Partners" WITH TEMPLATE = template0 ENCODING = 'UTF8' LOCALE_PROVIDER = libc LOCALE = 'Russian_Russia.1251';
    DROP DATABASE "Partners";
                     postgres    false            �            1259    16440    Partners    TABLE     O  CREATE TABLE public."Partners" (
    "Id" smallint NOT NULL,
    "IdTypeOfPartner" smallint NOT NULL,
    "Name" text NOT NULL,
    "LegalAdress" text NOT NULL,
    "INN" character varying(12) NOT NULL,
    "NameOfDirector" text NOT NULL,
    "Phone" character varying(20) NOT NULL,
    "Email" text NOT NULL,
    "Rating" smallint
);
    DROP TABLE public."Partners";
       public         heap r       postgres    false            �            1259    16439    Partners_Id_seq    SEQUENCE     �   CREATE SEQUENCE public."Partners_Id_seq"
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 (   DROP SEQUENCE public."Partners_Id_seq";
       public               postgres    false    220            �           0    0    Partners_Id_seq    SEQUENCE OWNED BY     I   ALTER SEQUENCE public."Partners_Id_seq" OWNED BY public."Partners"."Id";
          public               postgres    false    219            �            1259    16485    Partners_Products    TABLE     �   CREATE TABLE public."Partners_Products" (
    "Id" smallint NOT NULL,
    "IdPartner" smallint NOT NULL,
    "IdProduct" smallint NOT NULL,
    "Count" integer NOT NULL,
    "DateSelling" timestamp with time zone NOT NULL
);
 '   DROP TABLE public."Partners_Products";
       public         heap r       postgres    false            �            1259    16484    Partners_Products_Id_seq    SEQUENCE     �   CREATE SEQUENCE public."Partners_Products_Id_seq"
    AS smallint
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 1   DROP SEQUENCE public."Partners_Products_Id_seq";
       public               postgres    false    226            �           0    0    Partners_Products_Id_seq    SEQUENCE OWNED BY     [   ALTER SEQUENCE public."Partners_Products_Id_seq" OWNED BY public."Partners_Products"."Id";
          public               postgres    false    225            �            1259    16458    Products    TABLE     �   CREATE TABLE public."Products" (
    "Id" smallint NOT NULL,
    "IdTypeOfProduct" smallint NOT NULL,
    "Name" text NOT NULL,
    "Article" text NOT NULL,
    "MinimalPrice" money NOT NULL
);
    DROP TABLE public."Products";
       public         heap r       postgres    false            �            1259    16457    Products_Id_seq    SEQUENCE     �   CREATE SEQUENCE public."Products_Id_seq"
    AS smallint
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 (   DROP SEQUENCE public."Products_Id_seq";
       public               postgres    false    224            �           0    0    Products_Id_seq    SEQUENCE OWNED BY     I   ALTER SEQUENCE public."Products_Id_seq" OWNED BY public."Products"."Id";
          public               postgres    false    223            �            1259    16431    TypesOfPartners    TABLE     i   CREATE TABLE public."TypesOfPartners" (
    "Id" smallint NOT NULL,
    "TypeOfPartner" text NOT NULL
);
 %   DROP TABLE public."TypesOfPartners";
       public         heap r       postgres    false            �            1259    16430    TypesOfPartners_Id_seq    SEQUENCE     �   CREATE SEQUENCE public."TypesOfPartners_Id_seq"
    AS smallint
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 /   DROP SEQUENCE public."TypesOfPartners_Id_seq";
       public               postgres    false    218            �           0    0    TypesOfPartners_Id_seq    SEQUENCE OWNED BY     W   ALTER SEQUENCE public."TypesOfPartners_Id_seq" OWNED BY public."TypesOfPartners"."Id";
          public               postgres    false    217            �            1259    16449    TypesOfProducts    TABLE     �   CREATE TABLE public."TypesOfProducts" (
    "Id" smallint NOT NULL,
    "TypeOfProduct" text NOT NULL,
    "TypeCoefficient" numeric NOT NULL
);
 %   DROP TABLE public."TypesOfProducts";
       public         heap r       postgres    false            �            1259    16448    TypesOfProducts_Id_seq    SEQUENCE     �   CREATE SEQUENCE public."TypesOfProducts_Id_seq"
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 /   DROP SEQUENCE public."TypesOfProducts_Id_seq";
       public               postgres    false    222            �           0    0    TypesOfProducts_Id_seq    SEQUENCE OWNED BY     W   ALTER SEQUENCE public."TypesOfProducts_Id_seq" OWNED BY public."TypesOfProducts"."Id";
          public               postgres    false    221            6           2604    16464    Partners Id    DEFAULT     p   ALTER TABLE ONLY public."Partners" ALTER COLUMN "Id" SET DEFAULT nextval('public."Partners_Id_seq"'::regclass);
 >   ALTER TABLE public."Partners" ALTER COLUMN "Id" DROP DEFAULT;
       public               postgres    false    219    220    220            9           2604    16488    Partners_Products Id    DEFAULT     �   ALTER TABLE ONLY public."Partners_Products" ALTER COLUMN "Id" SET DEFAULT nextval('public."Partners_Products_Id_seq"'::regclass);
 G   ALTER TABLE public."Partners_Products" ALTER COLUMN "Id" DROP DEFAULT;
       public               postgres    false    226    225    226            8           2604    16461    Products Id    DEFAULT     p   ALTER TABLE ONLY public."Products" ALTER COLUMN "Id" SET DEFAULT nextval('public."Products_Id_seq"'::regclass);
 >   ALTER TABLE public."Products" ALTER COLUMN "Id" DROP DEFAULT;
       public               postgres    false    224    223    224            5           2604    16434    TypesOfPartners Id    DEFAULT     ~   ALTER TABLE ONLY public."TypesOfPartners" ALTER COLUMN "Id" SET DEFAULT nextval('public."TypesOfPartners_Id_seq"'::regclass);
 E   ALTER TABLE public."TypesOfPartners" ALTER COLUMN "Id" DROP DEFAULT;
       public               postgres    false    217    218    218            7           2604    16473    TypesOfProducts Id    DEFAULT     ~   ALTER TABLE ONLY public."TypesOfProducts" ALTER COLUMN "Id" SET DEFAULT nextval('public."TypesOfProducts_Id_seq"'::regclass);
 E   ALTER TABLE public."TypesOfProducts" ALTER COLUMN "Id" DROP DEFAULT;
       public               postgres    false    222    221    222            �          0    16440    Partners 
   TABLE DATA           �   COPY public."Partners" ("Id", "IdTypeOfPartner", "Name", "LegalAdress", "INN", "NameOfDirector", "Phone", "Email", "Rating") FROM stdin;
    public               postgres    false    220   \4       �          0    16485    Partners_Products 
   TABLE DATA           e   COPY public."Partners_Products" ("Id", "IdPartner", "IdProduct", "Count", "DateSelling") FROM stdin;
    public               postgres    false    226   �6       �          0    16458    Products 
   TABLE DATA           `   COPY public."Products" ("Id", "IdTypeOfProduct", "Name", "Article", "MinimalPrice") FROM stdin;
    public               postgres    false    224   �7       �          0    16431    TypesOfPartners 
   TABLE DATA           B   COPY public."TypesOfPartners" ("Id", "TypeOfPartner") FROM stdin;
    public               postgres    false    218   �8       �          0    16449    TypesOfProducts 
   TABLE DATA           U   COPY public."TypesOfProducts" ("Id", "TypeOfProduct", "TypeCoefficient") FROM stdin;
    public               postgres    false    222   9       �           0    0    Partners_Id_seq    SEQUENCE SET     @   SELECT pg_catalog.setval('public."Partners_Id_seq"', 1, false);
          public               postgres    false    219            �           0    0    Partners_Products_Id_seq    SEQUENCE SET     I   SELECT pg_catalog.setval('public."Partners_Products_Id_seq"', 1, false);
          public               postgres    false    225            �           0    0    Products_Id_seq    SEQUENCE SET     @   SELECT pg_catalog.setval('public."Products_Id_seq"', 1, false);
          public               postgres    false    223            �           0    0    TypesOfPartners_Id_seq    SEQUENCE SET     F   SELECT pg_catalog.setval('public."TypesOfPartners_Id_seq"', 1, true);
          public               postgres    false    217            �           0    0    TypesOfProducts_Id_seq    SEQUENCE SET     G   SELECT pg_catalog.setval('public."TypesOfProducts_Id_seq"', 1, false);
          public               postgres    false    221            C           2606    16490 (   Partners_Products Partners_Products_pkey 
   CONSTRAINT     l   ALTER TABLE ONLY public."Partners_Products"
    ADD CONSTRAINT "Partners_Products_pkey" PRIMARY KEY ("Id");
 V   ALTER TABLE ONLY public."Partners_Products" DROP CONSTRAINT "Partners_Products_pkey";
       public                 postgres    false    226            =           2606    16466    Partners Partners_pkey 
   CONSTRAINT     Z   ALTER TABLE ONLY public."Partners"
    ADD CONSTRAINT "Partners_pkey" PRIMARY KEY ("Id");
 D   ALTER TABLE ONLY public."Partners" DROP CONSTRAINT "Partners_pkey";
       public                 postgres    false    220            A           2606    16463    Products Products_pkey 
   CONSTRAINT     Z   ALTER TABLE ONLY public."Products"
    ADD CONSTRAINT "Products_pkey" PRIMARY KEY ("Id");
 D   ALTER TABLE ONLY public."Products" DROP CONSTRAINT "Products_pkey";
       public                 postgres    false    224            ;           2606    16438 $   TypesOfPartners TypesOfPartners_pkey 
   CONSTRAINT     h   ALTER TABLE ONLY public."TypesOfPartners"
    ADD CONSTRAINT "TypesOfPartners_pkey" PRIMARY KEY ("Id");
 R   ALTER TABLE ONLY public."TypesOfPartners" DROP CONSTRAINT "TypesOfPartners_pkey";
       public                 postgres    false    218            ?           2606    16475 $   TypesOfProducts TypesOfProducts_pkey 
   CONSTRAINT     h   ALTER TABLE ONLY public."TypesOfProducts"
    ADD CONSTRAINT "TypesOfProducts_pkey" PRIMARY KEY ("Id");
 R   ALTER TABLE ONLY public."TypesOfProducts" DROP CONSTRAINT "TypesOfProducts_pkey";
       public                 postgres    false    222            D           2606    16625 &   Partners Partners_IdTypeOfPartner_fkey    FK CONSTRAINT     �   ALTER TABLE ONLY public."Partners"
    ADD CONSTRAINT "Partners_IdTypeOfPartner_fkey" FOREIGN KEY ("IdTypeOfPartner") REFERENCES public."TypesOfPartners"("Id") NOT VALID;
 T   ALTER TABLE ONLY public."Partners" DROP CONSTRAINT "Partners_IdTypeOfPartner_fkey";
       public               postgres    false    220    218    4667            F           2606    16610 2   Partners_Products Partners_Products_IdPartner_fkey    FK CONSTRAINT     �   ALTER TABLE ONLY public."Partners_Products"
    ADD CONSTRAINT "Partners_Products_IdPartner_fkey" FOREIGN KEY ("IdPartner") REFERENCES public."Partners"("Id") NOT VALID;
 `   ALTER TABLE ONLY public."Partners_Products" DROP CONSTRAINT "Partners_Products_IdPartner_fkey";
       public               postgres    false    4669    220    226            G           2606    16615 2   Partners_Products Partners_Products_IdProduct_fkey    FK CONSTRAINT     �   ALTER TABLE ONLY public."Partners_Products"
    ADD CONSTRAINT "Partners_Products_IdProduct_fkey" FOREIGN KEY ("IdProduct") REFERENCES public."Products"("Id") NOT VALID;
 `   ALTER TABLE ONLY public."Partners_Products" DROP CONSTRAINT "Partners_Products_IdProduct_fkey";
       public               postgres    false    224    226    4673            E           2606    16620 &   Products Products_IdTypeOfProduct_fkey    FK CONSTRAINT     �   ALTER TABLE ONLY public."Products"
    ADD CONSTRAINT "Products_IdTypeOfProduct_fkey" FOREIGN KEY ("IdTypeOfProduct") REFERENCES public."TypesOfProducts"("Id") NOT VALID;
 T   ALTER TABLE ONLY public."Products" DROP CONSTRAINT "Products_IdTypeOfProduct_fkey";
       public               postgres    false    222    224    4671            �   \  x���MnA���)� M��̎�d3Qfa�ȬV䅑bG�%Nl_ �����o�W=���	�鮪��jM���g��3ŷaNx��0�WaJmo�4��/���<���g�;^a9F�a���!�?���YS�S^�E���%���'��y�;�g���g�-}\�f�O��
as7U�eVic��ݡ��8�7����{�2�=j�Q�aH_��4]��2��`]���>�����B�E�|#��%?K��?�{rJ_���T:�6Qs���Y���v�P㌲�Q}[uR*���Ѡ_v��%K�;QH:��1�4ʹ�B}@.T䄨��^c������E���i49��ˬG38Y�I��T�h�c%x�P�)F̢���j��QIByo�?�E��jFG��&�jO/�9�]D��B�٬-�W8���E������B�%)�M�5i|p.��_u�]�'��)^4�ڋ̳誘��8�΁�(���T�bp��[e�]l��7<Aǫu~F/�d�����Ƚ��on��9�o4Zm�op����C�{��.��;�<B���D|�����b��Z��cy��z!�:i�j5�?���      �   �   x�u�K�0D���WT���Yz�s���r����8� )�2*k} ��{PI�������dT�mc,��#���a�&��:r�,Y�	��4�6��hI�{��a�s� bX���ĺF��ڐ���(EOϨ.3:,d3*V��� ���,=3���6!��<>ʝ/a�r�k!�W��f��J)?x�`!      �   7  x�u�MN�0���)|��������0IA��H,Ȃ=)��?I�r��x�THT��ɼ���c%��WjSE{�iI=�GIR�V+�E�>�$�H��I`����:L��_e$L���z��0cc�U
��J�=��ɑ V� ���%�Al���׬�16����#�[�nl�.���B	zAlG�ɾ<�68U��G��4Tk	�B��S�s�(})�ظr��9��#L�W���St�n�i��p�v�=6>�QH�$qUʀͱ�+J�3H�iqΏx�V���Ѷh����l�Jk��|]Eny\חY�� ��1�      �   )   x�3�0��8/L�0�0�0�0I��0�=... u�4      �   �   x�e���0�wU�������8��ȇH�`",E8-�uĊo^��ݛ ����_���!i/x0�>�/�f��F#�P$YH:�,2I��8�6D�q��"kt5�;��ٯ�[Q%X�$�Q�Q��L�Ax��^LU�1h�     