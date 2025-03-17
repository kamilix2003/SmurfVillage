# SmurfVillage

```plantuml
@startuml

class Entity {
    - id : uint
    - age : uint
    # location : string

    # Entity(location, age)
    - Entity(id, location, age)
}

note left of Entity::id
    Ids are assigned automaticaly via protected constructor
endnote

note left of Entity::"Entity(id, location, age)"
    Private constructor allows for overriding ids
endnote

class LivingBeing{
    - name : string
    # health : uint
    # energy : uint

    # LivingBeing(name, location)
}

note left of LivingBeing::"LivingBeing(name, location)"
    Constructor does not requier health or energy
    because those variable will be set based on
    derived class, for example Cat and Smurf will have
    different base health and energy
endnote

class Smurf {
    - hatColor : uint

    + Smurf(hatColor, name, location)
}

class Cat {
    - furColor : uint
    - furPattern : string

    + Cat(furColor, furPattern, name, location)
}

class NonLivingBeing {
    - material : string

    # NonLivingBeing(material, location)
}

class Building {
    - area : float
    - capacity : uint

    + Building(area, capacity, material, location)
}

class NaturalStructure {
    - harvestable : bool

    + NaturalStructure(harvestable, material, location)
}

Entity --> LivingBeing
Entity --> NonLivingBeing

LivingBeing --> Smurf
LivingBeing --> Cat

NonLivingBeing --> Building
NonLivingBeing --> NaturalStructure

@enduml
```

Any color variables can be later replace with Color class, for now colors are stored as three 8 bit value in order from G B R from least significant bit.

For most string variables, string type is temporary, to be replace by dedicated class



![alt text](image.png)