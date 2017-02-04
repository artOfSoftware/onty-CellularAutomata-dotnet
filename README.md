# README

This is a simple implementation of [Finite Cellular Automata](https://en.wikipedia.org/wiki/Cellular_automaton) using C#.

## Algorithms

The algorithms implemented include:

1. Conway's Game of Life
1. North-East-Center Min
1. North-East-Center Max
1. North-East-Center Median
1. Swap 0's and 2's

It also supports specifying a custom transformation using a specialized language.  Here are some samples:

Assume current point has coordinates (a,b) at time=t

The function below will find a minimum value among values at the points (a+1,b+2) and (a,b), and assign to point (a,b) for time=t+1
```
min(   (1,2) (0,0)  )
```

The function below will find a maximum value among values at the points (a-1,b-1) and (a-1,b), and assign it to temp variable k.
Then it will find minimum value among values among point (a+1,b+2), point (a,b), and temp variable k.
Result will be assigned to point (a,b) for time=t+1

```
min(   (1,2) (0,0) max( (-1,-1) (-1,0) )   )
```

This one you should be able to figure out on your own.

```
max(   
  (1,2) 
  (0,0) 
  max( (-1,-1) (-1,0) )
  mid( (1,1) (2,2)  ) 
)
```




## Sample view

![screen shot of version 0.5](https://github.com/ontytoom/Toom.CellularAutomata/blob/master/Images/Cellular%20Automata%200.05%20screenshot.png)
