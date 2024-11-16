package main

import (
	"fmt"
	"math"
)

func main() {
	arr := [][]int32{[]int32{1, 2, 3}, []int32{4, 5, 6}, []int32{9, 8, 9}}

	var sumLeft int32 = 0
	var sumRight int32 = 0

	for i := 0; i < len(arr); i++ {
		sumLeft = sumLeft + arr[i][i]
		sumRight = sumRight + arr[i][len(arr)-1-i]
	}

	res := math.Abs(float64(sumLeft) - float64(sumRight))

	fmt.Println(res)
}
