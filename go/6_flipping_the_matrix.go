package main

import (
	"fmt"
	"math"
)

func main() {
	matrix := [][]int32{[]int32{112, 42, 83, 119}, []int32{56, 125, 56, 49}, []int32{15, 78, 101, 43}, []int32{62, 98, 114, 108}}

	sum := 0.0
	n := len(matrix)
	area := len(matrix) / 2
	for i := 0; i < area; i++ {
		for j := 0; j < area; j++ {
			sum += math.Max(float64(matrix[i][j]),
				math.Max(float64(matrix[i][n-1-j]),
					math.Max(float64(matrix[n-1-i][j]), float64(matrix[n-1-i][n-1-j]))))
		}
	}

	fmt.Println(int32(sum))
}
