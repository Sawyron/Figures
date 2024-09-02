CREATE TABLE products (
  id int IDENTITY PRIMARY KEY,
  name varchar(15) NOT NULL,
);

CREATE TABLE categories (
  id int IDENTITY PRIMARY KEY,
  name varchar(15) NOT NULL
);

CREATE TABLE products_to_categories(
  product_id int FOREIGN KEY REFERENCES products(id),
  category_id int FOREIGN KEY REFERENCES categories(id),
  PRIMARY KEY (product_id, category_id),
);