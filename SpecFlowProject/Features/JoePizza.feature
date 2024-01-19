Feature: JoePizza
![Calculator](https://specflow.org/wp-content/uploads/2020/09/calculator.png)
Simple calculator for adding **two** numbers

Link to a feature: [Calculator](SpecFlowProject/Features/Calculator.feature)
***Further read***: **[Learn more about how to generate Living Documentation](https://docs.specflow.org/projects/specflow-livingdoc/en/latest/LivingDocGenerator/Generating-Documentation.html)**

@mytag
Scenario:Retrieve Pizza Name
     Given a pizza where name is "VegLoaded"
    When GetName method is called
   Then the result should VegLoaded


      Scenario:Retrieve Pizza Price
     Given a pizza where price is 1000
    When GetPrice method is called
   Then the result should 1000

  
      Scenario:Retrieve Pizza Quantity
     Given a pizza where quantity is 1
    When GetQuantity method is called
   Then the result should be 1

