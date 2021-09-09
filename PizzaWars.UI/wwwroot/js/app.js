let app = new Vue
    ({
        el: '#app',
        data: {
            pizzas: [],
            pizzaUrl: "",
            pizzaUrl2: ""

        },
        mounted() {
            this.getData();
            this.getPizzaUrl();
            this.getPizzaUrl2();
        },
        methods: {
            getData() {
                axios.get('/Pizza/PizzaLists')
                    .then(res => {
                        this.pizzas = res.data;
                        console.log(this.pizzas);
                    })
                    .catch(err => {
                        console.log(err)
                    });
            },

                getPizzaUrl() {
                    axios.get('https://foodish-api.herokuapp.com/api/images/pizza')
                        .then(res => {
                            this.pizzaUrl = res.data;
                            
                            console.log(this.pizzaUrl);
                        })
                        .catch(err => {
                            console.log(err)
                        });
            },
            getPizzaUrl2() {
                axios.get('https://foodish-api.herokuapp.com/api/images/pizza')
                    .then(res => {
                        this.pizzaUrl2 = res.data;
                        console.log(this.pizzaUrl);
                    })
                    .catch(err => {
                        console.log(err)
                    });
            },
            
        }
    })