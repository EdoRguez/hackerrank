package main

import "fmt"

func main() {
	a := [7]int32{1, 2, 3, 4, 3, 2, 1}

	values := make(map[int]bool)
	for _, el := range a {
		if _, exists := values[int(el)]; exists {
			values[int(el)] = false
		} else {
			values[int(el)] = true
		}
	}

	for _, v := range a {
		if values[int(v)] {
			fmt.Println(v)
			return
		}
	}
}
