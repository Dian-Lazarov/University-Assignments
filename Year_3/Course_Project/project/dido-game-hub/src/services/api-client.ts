import axios from "axios";

export default axios.create({
  baseURL: "https://api.rawg.io/api",
  params: {
    key: "737aa4c0c8af4e42aff5a65bc96dd4c5",
  },
});
