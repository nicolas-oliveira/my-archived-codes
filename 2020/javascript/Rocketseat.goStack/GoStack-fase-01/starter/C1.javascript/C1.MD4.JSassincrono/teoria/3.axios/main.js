axios.get('https://api.github.com/users/nicolas-oliveira')
.then(
    function(response){
        console.log(response.data);
    })
.catch(
    function(error) {
        console.log(error);
    });
