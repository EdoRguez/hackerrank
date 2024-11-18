package main

import (
	"fmt"
	"strings"
	"unicode"
)

func main() {
	s := "www.abc.xy"
	k := 87

	alphabet := []rune("abcdefghijklmnopqrstuvwxyz")
	var res strings.Builder

	for _, char := range s {
		currentChar := unicode.ToLower(char)
		idx := strings.IndexRune(string(alphabet), currentChar)
		if idx != -1 {
			newIdx := idx + k
			for newIdx > len(alphabet)-1 {
				newIdx -= len(alphabet)
			}

			var charToAdd rune = alphabet[newIdx]
			if unicode.IsUpper(char) {
				charToAdd = unicode.ToUpper(charToAdd)
			}

			res.WriteRune(charToAdd)
		} else {
			res.WriteRune(char)
		}
	}

	fmt.Println(res.String())
}
