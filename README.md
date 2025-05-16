# UML Graph WordScramble

``` mermaid
classDiagram
    class `IView`
    class `CompareByName`
    class `program`
    class `View`
    class `Controller`
    class `Player`
    class `PlayerOrder`

    IView <|-- View
    Player *-- CompareByName
    program <-- Controller
    Controller <--> View
    Controller <-- PlayerOrder
    Controller <-- Player 
    ```