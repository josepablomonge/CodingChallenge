$(document).ready(function () {
    ko.applyBindings(new AppViewModel());
});

function AppViewModel() {
    var self = this;

    self.SelectedUserId = ko.observable();
    self.UserList = ko.observableArray();
    self.ProjectList = ko.observableArray();

    self.SelectedUserId.subscribe(function (selectedUser) {
        $.ajax({
            url: '/api/project/?userid=' + selectedUser.id(),
            type: "GET",
            datatype: 'json',
            success: function (data) {
                var mappedProject = $.map(data, function (project) { return new ProjectViewModel(project); });
                self.ProjectList(mappedProject);
            },
            error: function (x) {
                alert(x.statusText);
            }
        });
    });

    self.GetUsers = function () {
        $.ajax({
            type: "GET",
            dataType: "json",
            url: '/api/user',
            success: function (data) {
                var mappedUser = $.map(data, function (user) { return new UserViewModel(user); });
                self.UserList(mappedUser);
            },
            error: function () {

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
    self.startDate = ko.observable(data.startDate);
    self.endDate = ko.observable(data.endDate);
    self.timeToStart = ko.observable(data.timeToStart);
}