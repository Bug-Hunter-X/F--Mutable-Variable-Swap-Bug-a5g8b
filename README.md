# F# Mutable Variable Swap Bug

This repository demonstrates a common bug in F# involving the incorrect swapping of mutable variables.

## Bug Description

The `swap` function attempts to swap the values of two mutable variables, `x` and `y`. However, due to a misunderstanding of how mutable variables are handled in F#, the swap does not work as intended.

## Bug Reproduction

1. Clone this repository.
2. Open the `bug.fs` file.
3. Run the code. You will observe that the values of `x` and `y` are not correctly swapped.

## Solution

The solution involves a correct implementation of the `swap` function, ensuring that the values are correctly exchanged.

See `bugSolution.fs` for the corrected code.