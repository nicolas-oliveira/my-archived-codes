import socketio from 'socket.io-client';

const socket = socketio('http://exp://192.168.1.108:3333', {
    autoConnect: false,
});

function subscribeToNewDevs(subscribeFunction) {
    socket.on('new-dev', subscribeFunction);
}

function connect(latitude, longitude, techs) {
    socket.io.opts.query = {
        latitude,
        longitude,
        techs,
    }
    socket.connect();

    socket.on('message', text => { 
        console.log(text);
    });
}

function disconnect() {
    if(socket.connected) {
        socket.disconnected();
    }
}

export {
    connect,
    disconnect,
    subscribeToNewDevs,
}