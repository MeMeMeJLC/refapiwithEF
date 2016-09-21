var ViewModel = function () {
    var self = this;
    self.gamePlayers = ko.observableArray();
    self.error = ko.observable();

    var gamePlayersUri = '/api/gamePlayers/';

    function ajaxHelper(uri, method, data) {
        self.error(''); // Clear error message
        return $.ajax({
            type: method,
            url: uri,
            dataType: 'json',
            contentType: 'application/json',
            data: data ? JSON.stringify(data) : null
        }).fail(function (jqXHR, textStatus, errorThrown) {
            self.error(errorThrown);
        });
    }

    function getAllGamePlayers() {
        ajaxHelper(gamePlayersUri, 'GET').done(function (data) {
            self.gamePlayers(data);
        });
    }

    // Fetch the initial data.
    getAllGamePlayers();
};

ko.applyBindings(new ViewModel());