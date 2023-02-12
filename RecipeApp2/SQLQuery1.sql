SELECT * FROM Recipe
 
 select * from Ingredient

SELECT a.Name FROM Ingredient a
 INNER JOIN RecipeIngredient b ON a.Id = b.IngredientId
 WHERE b.RecipeId = 1

UPDATE Recipe
 SET Name = 'Salad'
 WHERE Id = 1

INSERT INTO Recipe
 VALUES ('Salad 4', 50, 'Combine Stuff')

DELETE FROM Recipe
 WHERE Id = 3