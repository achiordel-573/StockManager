-- DROP SCHEMA public;

CREATE SCHEMA public AUTHORIZATION pg_database_owner;

-- DROP SEQUENCE public.debit_invoices_id_seq;

CREATE SEQUENCE public.debit_invoices_id_seq
	INCREMENT BY 1
	MINVALUE 1
	MAXVALUE 2147483647
	START 1
	CACHE 1
	NO CYCLE;
-- DROP SEQUENCE public.debit_invoices_product_id_seq;

CREATE SEQUENCE public.debit_invoices_product_id_seq
	INCREMENT BY 1
	MINVALUE 1
	MAXVALUE 2147483647
	START 1
	CACHE 1
	NO CYCLE;
-- DROP SEQUENCE public.incoming_invoices_id_seq;

CREATE SEQUENCE public.incoming_invoices_id_seq
	INCREMENT BY 1
	MINVALUE 1
	MAXVALUE 2147483647
	START 1
	CACHE 1
	NO CYCLE;
-- DROP SEQUENCE public.incoming_invoices_product_id_seq;

CREATE SEQUENCE public.incoming_invoices_product_id_seq
	INCREMENT BY 1
	MINVALUE 1
	MAXVALUE 2147483647
	START 1
	CACHE 1
	NO CYCLE;
-- DROP SEQUENCE public.incoming_invoices_provider_id_seq;

CREATE SEQUENCE public.incoming_invoices_provider_id_seq
	INCREMENT BY 1
	MINVALUE 1
	MAXVALUE 2147483647
	START 1
	CACHE 1
	NO CYCLE;
-- DROP SEQUENCE public.products_id_seq;

CREATE SEQUENCE public.products_id_seq
	INCREMENT BY 1
	MINVALUE 1
	MAXVALUE 2147483647
	START 1
	CACHE 1
	NO CYCLE;
-- DROP SEQUENCE public.providers_id_seq;

CREATE SEQUENCE public.providers_id_seq
	INCREMENT BY 1
	MINVALUE 1
	MAXVALUE 2147483647
	START 1
	CACHE 1
	NO CYCLE;
-- DROP SEQUENCE public.sale_reports_id_seq;

CREATE SEQUENCE public.sale_reports_id_seq
	INCREMENT BY 1
	MINVALUE 1
	MAXVALUE 2147483647
	START 1
	CACHE 1
	NO CYCLE;-- public.products определение

-- Drop table

-- DROP TABLE public.products;

CREATE TABLE public.products (
	id int4 GENERATED ALWAYS AS IDENTITY( INCREMENT BY 1 MINVALUE 1 MAXVALUE 2147483647 START 1 CACHE 1 NO CYCLE) NOT NULL,
	title varchar NOT NULL,
	count int4 DEFAULT 0 NOT NULL,
	CONSTRAINT products_pk PRIMARY KEY (id)
);


-- public.providers определение

-- Drop table

-- DROP TABLE public.providers;

CREATE TABLE public.providers (
	id int4 GENERATED ALWAYS AS IDENTITY( INCREMENT BY 1 MINVALUE 1 MAXVALUE 2147483647 START 1 CACHE 1 NO CYCLE) NOT NULL,
	title varchar NOT NULL,
	phone text NULL,
	CONSTRAINT providers_pk PRIMARY KEY (id)
);


-- public.debit_invoices определение

-- Drop table

-- DROP TABLE public.debit_invoices;

CREATE TABLE public.debit_invoices (
	id int4 GENERATED ALWAYS AS IDENTITY( INCREMENT BY 1 MINVALUE 1 MAXVALUE 2147483647 START 1 CACHE 1 NO CYCLE) NOT NULL,
	"date" timestamp DEFAULT now() NOT NULL,
	count int4 DEFAULT 0 NOT NULL,
	product_id int4 NOT NULL,
	CONSTRAINT debit_invoices_pk PRIMARY KEY (id),
	CONSTRAINT debit_invoices_products_fk FOREIGN KEY (product_id) REFERENCES public.products(id) ON DELETE CASCADE ON UPDATE CASCADE
);


-- public.incoming_invoices определение

-- Drop table

-- DROP TABLE public.incoming_invoices;

CREATE TABLE public.incoming_invoices (
	id int4 GENERATED ALWAYS AS IDENTITY( INCREMENT BY 1 MINVALUE 1 MAXVALUE 2147483647 START 1 CACHE 1 NO CYCLE) NOT NULL,
	"date" timestamp DEFAULT now() NOT NULL,
	product_count int4 DEFAULT 0 NOT NULL,
	price int4 DEFAULT 0 NOT NULL,
	provider_id int4 GENERATED ALWAYS AS IDENTITY( INCREMENT BY 1 MINVALUE 1 MAXVALUE 2147483647 START 1 CACHE 1 NO CYCLE) NOT NULL,
	product_id int4 NOT NULL,
	CONSTRAINT incoming_invoices_pk PRIMARY KEY (id),
	CONSTRAINT incoming_invoices_products_fk FOREIGN KEY (product_id) REFERENCES public.products(id) ON DELETE CASCADE ON UPDATE CASCADE
);

-- Table Triggers

create trigger ins_incoming_invoice after
insert
    on
    public.incoming_invoices for each row execute function modify_insert_product_counter();
create trigger del_incoming_invoice after
delete
    on
    public.incoming_invoices for each row execute function modify_delete_product_counter();


-- public.sale_reports определение

-- Drop table

-- DROP TABLE public.sale_reports;

CREATE TABLE public.sale_reports (
	id int4 GENERATED ALWAYS AS IDENTITY( INCREMENT BY 1 MINVALUE 1 MAXVALUE 2147483647 START 1 CACHE 1 NO CYCLE) NOT NULL,
	"date" timestamp DEFAULT now() NOT NULL,
	product_id int4 NOT NULL,
	count int4 DEFAULT 0 NOT NULL,
	price int4 DEFAULT 0 NOT NULL,
	CONSTRAINT sale_reports_pk PRIMARY KEY (id),
	CONSTRAINT sale_reports_products_fk FOREIGN KEY (product_id) REFERENCES public.products(id) ON DELETE CASCADE ON UPDATE CASCADE
);



-- DROP FUNCTION public.modify_insert_product_counter();

CREATE OR REPLACE FUNCTION public.modify_insert_product_counter()
 RETURNS trigger
 LANGUAGE plpgsql
AS $function$
begin 
	update products set count = count + new.product_count
	where products.id = new.product_id;
	return null;
end
$function$
;