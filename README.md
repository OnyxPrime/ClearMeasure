# Clear Measure

This repository holds the homework assignment for the Clear Measure interview process.

## Assignment

Improve the code worked on during the live technical interview to include the following new features:

1. Allow custom operands for modulus operations with corresponding strings to be output.

2. Add unit tests covering the custom library created.

## Problems

One of the problems seen during initial development and testing was scale. As the upperbound goes up, the amount of memory used goes up due to the number of `string` objects being created. While the parameter `upperBound` itself can be as high as 2147483647, the return type of `array` cannot hold this many items. The amount of items an `array` can hold is determined by the type of items with in it. In testing, I found the amount of memory being allocated at maximum array length for stings to be very high, upwards of 17GB. For speed and performance, I implemented an upper bound limit of 50000000.

## Future Improvements

- Add a variable lower bound to give the client the ability to get the values of those numbers above 50000000, but still limiting the amount of items processed to 50000000.

- Add custom type for modulators, if the `tuple` parameter is too cumbersome for the clients.
