import axios from "axios";
const axiosInstance = axios.create
({
    baseURL: "http://cep.awesomeapi.com.br/json/",
    headers: {
        "Content-type":"aplication/json"
    }
    
})
export default axiosInstance;