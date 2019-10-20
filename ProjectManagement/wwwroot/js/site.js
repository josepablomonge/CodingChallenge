$(document).ready(function () {
    ko.applyBindings(new AppViewModel());
});

function AppViewModel() {
    var self = this;

    self.showErrorMessage = ko.observable(false);
    self.errorMessage = ko.observable();
    self.SelectedUserId = ko.observable();
    self.UserList = ko.observableArray();
    self.ProjectList = ko.observableArray();

    self.SelectedUserId.subscribe(function (selectedUser) {
        self.showErrorMessage(false);
        $.ajax({
            url: '/api/project/?userid=' + selectedUser.id(),
            type: "GET",
            datatype: 'json',
            success: function (data) {
                var mappedProject = $.map(data, function (project) { return new ProjectViewModel(project); });
                self.ProjectList(mappedProject);
            },
            error: function (x) {
                self.errorMessage(x.statusText);
                self.showErrorMessage(true);
            }
        });
    });

    self.GetUsers = function () {
        self.showErrorMessage(false);
        $.ajax({
            type: "GET",
            dataType: "json",
            url: '/api/user',
            success: function (data) {
                var mappedUser = $.map(data, function (user) { return new UserViewModel(user); });
                self.UserList(mappedUser);
            },
            error: function (x) {
                self.errorMessage(x.statusText);
                self.showErrorMessage(true);
            }
        });
    };

    self.GetUsers();
}

function UserViewModel(data) {
    var self = this;
    self.id = ko.observable(data.id);
    self.userName = ko.observable(data.firstName + " " + data.lastName);
}

function ProjectViewModel(data) {
    var self = this;
    self.projectId = ko.observable(data.projectId);
    self.credits = ko.observable(data.credits);
    self.status = ko.observable(data.status);
    self.startDate = ko.observable(moment(data.startDate).format('MM-DD-YYYY'));
    self.endDate = ko.observable(moment(data.endDate).format('MM-DD-YYYY'));
    self.timeToStart = ko.observable(data.timeToStart);
}