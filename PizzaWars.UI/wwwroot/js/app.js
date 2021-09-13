
let app = new Vue
    ({
        el: '#app',
        data: {
            pizzas: [],
            pizzaUrl: "",
            pizzaListUrl: [],
            pizzaListLenght: 0,
            counter: 0,
            toggleTopping: false,
            extraToppings: [],
            
        },
        async mounted() {
            await this.getData();
            console.log(this.pizzas.length);
            for (let i = 0; i < this.pizzas.length; i++) {
              await this.getPizzaUrl();
            }
/*            console.log(this.pizzaListUrl);*/
        },
        methods: {
           async getData() {
                const pizza = await axios.get('/Pizza/PizzaLists')
 /*           console.log(pizza);*/
                this.pizzas = pizza.data
            },
           async getPizzaUrl() {
               try {
                   const pizzaImg = await axios.get('https://foodish-api.herokuapp.com/api/images/pizza')
                   console.log(pizzaImg.data);
                   this.pizzaUrl = pizzaImg.data;
                   this.pizzaListUrl.push(this.pizzaUrl.image);
               } catch (e) {
                   console.log(e);
               }
               this.counter++;
            },
            deletePizza(name) {
                this.pizzas = this.pizzas.filter(function (obj) {
                    return obj.name !== name;
                });
                this.counter--;
                console.log(this.counter);
            },
            toogleAddTopping() {
                this.toggleTopping = !this.toggleTopping
            }

        }
    })