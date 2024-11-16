package main

import "fmt"

func main() {
	arr := []int32{1, 1, 3, 2, 1}
	res := make([]int32, 100)

	for _, el := range arr {
		res[el]++
	}

	fmt.Println(res)
}
