SELECT p.name AS product_name, c.name AS category_name
FROM products AS p LEFT JOIN products_to_categories AS ptc
  ON p.id = ptc.product_id
LEFT JOIN categories AS c
  ON ptc.category_id = c.id; 