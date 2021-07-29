import React from "react";
import {
  BrowserRouter as Router,
  Switch,
  Route,
  Link
} from "react-router-dom";
import HomePage from "./pages/HomePage";
import LoginPage from "./pages/LoginPage";
import BookList from "./pages/Book/BookList";
import CategoryList from "./pages/Category/CategoryList";
import CreateBook from "./pages/Book/CreateBook";
import CreateCategory from "./pages/Category/CreateCategory";

const App = () => {
  return (
    <Router>
          <div>
            <ul>
              <Link style={{ marginRight: '15px' }} to="/login">Login</Link>
              <Link style={{ marginRight: '15px' }} to="/book">Book</Link>
              <Link style={{ marginRight: '15px' }} to="/category">Category</Link>
            </ul>
          </div>

      <Switch>
        <Route path="/login" exact>
          <LoginPage
          />
        </Route>
        <Route path="/book">
          <BookList />
        </Route>
        <Route path="/category">
          <CategoryList />
        </Route>
        <Route path="/createBook">
          <CreateBook />
        </Route>
        <Route path="/createCategory">
          <CreateCategory />
        </Route>
        <Route exact path="/">
          <HomePage />
        </Route>
      </Switch>
    </Router>
  );
}

export default App;