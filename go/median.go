package main

import "fmt"

func main() {
	arr := [5]int{4, 6, 5, 3, 2}

	for i := 1; i < len(arr); i++ {
		j := i
		for j > 0 && arr[j] < arr[j-1] {
			temp := arr[j]
			arr[j] = arr[j-1]
			arr[j-1] = temp
			j--
		}
	}

	fmt.Println(len(arr) / 2)
}
