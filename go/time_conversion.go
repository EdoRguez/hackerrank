package main

import (
	"fmt"
	"strconv"
	"strings"
)

func main() {
	s := "11:01:45PM"

	var sb strings.Builder
	num, _ := strconv.Atoi(s[0:2])

	if strings.Contains(s, "A") {
		if num == 12 {
			sb.WriteString("00")
			sb.WriteString(s[2 : len(s)-2])
			fmt.Println(sb.String())
		} else {
			fmt.Println(s[0 : len(s)-2])
		}
	} else {
		if num == 12 {
			sb.WriteString("12")
			sb.WriteString(s[2 : len(s)-2])
			fmt.Println(sb.String())
		} else {
			sb.WriteString(strconv.Itoa(num + 12))
			sb.WriteString(s[2 : len(s)-2])
			fmt.Println(sb.String())
		}
	}
}
