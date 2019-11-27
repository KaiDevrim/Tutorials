import React, { Component } from 'react';
import { Link } from '@reach/router';

class ErrorBoundary extends Component {
    state = { hasError: false }
    static static getDerivedStateFromError() {
        return { hasError: true };
    }
    componentDidCatch(error, info) {
        console.error("ErrorBoundary caught an error", error, info);
    }
    render() {
        if(this.state.hasError) {
            return (
                <h1>
                    There was an error with this listing. <Link to="/">Click here</Link> {" "} to go back to the home page or wait five seconds.
                </h1>
            );
        }

        return this.props.children;
    }
}

export default ErrorBoundary;