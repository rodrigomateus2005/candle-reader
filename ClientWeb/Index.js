const connection = new signalR.HubConnectionBuilder()
    .withUrl("http://localhost:5010/BotHub")
    .configureLogging(signalR.LogLevel.Information)
    .build();

connection.start().then(function () {
    console.log("connected");
});

connection.on("OnPriceChange", (retorno) => {
    console.log(retorno);
});

function Conectar() {
	connection.invoke("Imprimir", "Ronaldo").catch(err => {
		console.error(err.toString());
	});
}
